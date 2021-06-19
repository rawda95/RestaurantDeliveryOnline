
function ConvertViewBagToList(data) {
    return JSON.parse(data.replace(/[\u0000-\u001F]+/g, ""));
}

function FormDataToJSON(FormElement) {
    var formData = new FormData(FormElement);
    var ConvertedJSON = {};
    for (const [key, value] of formData.entries()) {
        ConvertedJSON[key] = value.trim();
    }

    return ConvertedJSON
}


$(document).on("click", "#NextBtn", () => {
    let isValid = CheckCurrentStepValdation();
    if (isValid) {
       
      MoveNextFromStepToStep(StepNumber + 1); 
    }
});
$(document).on("click", ".BackBtn", () => {
    
    MoveBackFromStepToStep();
    
});

//$(document).on("click", "#step3Link", () => {
//    let isValid = CheckCurrentStepValdation(3);
//    if (isValid) {

//        MoveNextFromStepToStep(3);
//        $(".NextBtn").attr("disabled", true);

//    }
//});

//$(document).on("click", "#step2Link", () => {
//    let isValid = CheckCurrentStepValdation(2);
//    if (isValid) {

//        MoveNextFromStepToStep(2);
//        $("#TotalPrice").text(`${GetTotalPrice()}$`);
//    }
//});

//$(document).on("click", "#step1Link", () => {
//    let isValid = CheckCurrentStepValdation(1);
//    if (isValid) {

//        MoveNextFromStepToStep(1);
//        $(".BackBtn").attr("disabled", true);
//        $("#step3Link").addClass("disabled");

//    }
//});

function CheckCurrentStepValdation() {

        if (StepNumber == 1) {
            return CheckFirstStepValidation();
        }
        else if (StepNumber == 2) {
            return ChecksecondStepValidation();
        }
    
    
        return true;
    
};
function CheckFirstStepValidation() {
    if ($(".productCheck:checked").length == 0) {

        swal({
            //text: "Your webinar was added to your cart successfully.",
            icon: 'error',
            title: "Please Select a product First",
        });
        return false;
    } else {
        AddSelectedProductToList();
        AddCartData();
        ChangeTotalTexts();
        return true;
    }
}
function ChecksecondStepValidation() {
    var name = ChakeInputValidation("#Name", "#SpanName");
    var Phone = ChakeInputValidation("#Phone", "#SpanPhone");
    var Email = ChakeInputValidation("#Email", "#SpanEmail");

    var Address = ChakeInputValidation("#Address", "#SpanAddress");

    if (name && Phone && Address && Email) {
        User.Name = $("#Name").val(); 
        User.Phone = $("#Phone").val();
        User.Address = $("#Address").val(); 
        User.Email = $("#Email").val();

        return true;
    } else {
        return false;
    }

    
}

function MoveNextFromStepToStep(NewStepNumber) {
    $(`#Step${NewStepNumber}`).removeAttr("style");
    $(`#Step${StepNumber}`).attr("style", 'display: none');
    StepNumber = NewStepNumber;


    if (StepNumber == 1) {
        $(".BackBtn").attr("disabled", true);
    } else {
        $(".BackBtn").removeAttr("disabled");

    }
    if (StepNumber == 3) {
        AddCartData();
        $("#NextBtn").attr("style", "display: none");
        $("#CheckOutBtn").removeAttr("style");

    } else {
        $("#NextBtn").removeAttr("style");
        $("#CheckOutBtn").attr("style", "display: none");


    }
}

function MoveBackFromStepToStep() {
    $(`#Step${StepNumber-1}`).removeAttr("style");
    $(`#Step${StepNumber}`).attr("style", 'display: none');

    StepNumber = StepNumber - 1;

    if (StepNumber == 1) {
        $(".BackBtn").attr("disabled", true);
    } else {
        $(".BackBtn").removeAttr("disabled");

    }
    if (StepNumber == 3) {
        AddCartData();
        $("#NextBtn").attr("style", "display: none");
        $("#CheckOutBtn").removeAttr("style");

    } else {
        $("#NextBtn").removeAttr("style");
        $("#CheckOutBtn").attr("style", "display: none");


    }
   
}

function AddSelectedProductToList() {
    let productCheckList = $(".productCheck:checked");
    var productCheckListIds = $(".productCheck:checked").map(function () { return $(this).attr("productId"); }).get();
    SelectedProducrtItems = SelectedProducrtItems.filter(e => productCheckListIds.some(d => d == e.id));


    for (let i = 0; i < productCheckList.length; i++) {
        
        let productId = $(productCheckList[i]).attr("productId")
        if (SelectedProducrtItems.filter(e => e.id == productId).length == 0) {
            let ProducrtItem = ProducrtItems.filter(e => e.id == productId)[0];
            ProducrtItem.Quantity = 1;
            SelectedProducrtItems.push(ProducrtItem);
        }
    }

}

function GetTotalPrice() {
    let total = SelectedProducrtItems.map(item => item.price * item.Quantity).reduce((prev, next) => prev + next);

    return total;
     
}


$(document).on("blur", "#Name", () => {
    ChakeInputValidation("#Name", "#SpanName");
});

$(document).on("blur", "#Phone", () => {
    ChakeInputValidation("#Phone", "#SpanPhone");
});

$(document).on("blur", "#Email", () => {
    ChakeInputValidation("#Email", "#SpanEmail");
});

$(document).on("blur", "#Address", () => {
    ChakeInputValidation("#Address", "#SpanAddress");
});


function ChakeInputValidation(input,spanValdation) {
    if ($(input).val() == "") {
        $(spanValdation).text("this Falid is required");
        return false;
    } else {
        $(spanValdation).text("");

        return true;
    }
}


function AddCartData() {
    AddProductItemToCart();
    AddUserDataToCart();
    ChangeTotalTexts();

}

function AddProductItemToCart() {
   $("#ProductList").html("");
    for (let i = 0; i < SelectedProducrtItems.length; i++) {
        let Producrt = SelectedProducrtItems[i];
        let str = `<tr id='${Producrt.id}'>
                
                <td >
                    <h6>${Producrt.name}</h6>
                </td>
                <td class='priceValue' price='${Producrt.price}'>${Producrt.price}$</td>
                <td>
                    <div style="width: 135px;margin: 0 auto;">
                        <input type="number" ProducrtId='${Producrt.id}' class="Quantity" onchange="changeQuantity(this)" value='${Producrt.Quantity}' min="1" max="1000" step="1" />
                    </div>
                </td>
                <td class='total'>${Producrt.price}$</td>
                <td>
                    <button  ProducrtId='${Producrt.id}' onclick='DeleteProductFromCart("${Producrt.id}")' class="DeleteProduct">x</button>
                </td>
            </tr>`;
        $("#ProductList").append(str);
    }
}   
function changeQuantity(elem) {
    let PriceElem = $(elem).closest("tr").find(".priceValue");
    let TotalElem = $(elem).closest("tr").find(".total");

    let Quantity = $(elem).val();
    let producrtid = $(elem).attr("Producrtid");
    changeQuantityInList(producrtid, Quantity);
    let total = Quantity * PriceElem.attr("price");
    TotalElem.text(`${total}$`);


    ChangeTotalTexts();
}

function changeQuantityInList(producrtid, Quantity) {
    Producrt = SelectedProducrtItems.filter(e => e.id == producrtid)[0];
    Producrt.Quantity = Quantity;
}
function AddUserDataToCart() {
    $("#UserName").text(User.Name);
    $("#UserPhone").text(User.Phone);
    $("#UserEmail").text(User.Email);
    $("#UserAddress").text(User.Address);

}

function DeleteProductFromCart(id) {
    SelectedProducrtItems = SelectedProducrtItems.filter(e => e.id != id);

    $(`.productCheck[productid=${id}]`)[0].checked = false
    $(`#${id}`).remove();
    if (SelectedProducrtItems.length == 0) {
        $("#SubTotal").text(`${0}$`)
        $("#Total").text(`${0}$`)
        $("#TotalPrice").text(`${0}$`);
        $("#CheckOutBtn").attr("style", "display: none");

    } else {
        ChangeTotalTexts();

    }

}

function ChangeTotalTexts() {

    let total = GetTotalPrice();
    $("#SubTotal").text(`${total}$`)
    $("#Total").text(`${total}$`)
    $("#TotalPrice").text(`${total}$`);

}

$(document).on("click", "#CheckOutBtn", () => {
    $('.overlay-spinner').css('display', 'flex');
    let Model = {
        User: User,
        Products: SelectedProducrtItems
    };
    $.ajax({
        cache: false,
        url: "/Restaurant/CheckOut",
        type: "POST",
        data: JSON.stringify( Model) ,
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
      
        success: function (response) {
            $('.overlay-spinner').css('display', 'none');
            if (response) {
                swal({
                    //text: "Your webinar was added to your cart successfully.",
                    icon: 'success',
                    title: "you have successfully checkout",
                }).then((result) => {

                    location.reload();
                });
            } else {
                swal({
                    //text: "Your webinar was added to your cart successfully.",
                    icon: 'error',
                    title: "There is an error access please try again later",
                }).then((result) => {

                    location.reload();
                });
            }
          
        }
    });
});