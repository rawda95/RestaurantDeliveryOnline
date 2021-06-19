function RestaurantSearch(){
    if (FormValidation()) {
        $('.overlay-spinner').css('display', 'flex');
        let form = $("#SearchForm")[0];
        var formData = new FormData(form);
        $.ajax({
            cache: false,
            url: $(form).attr('action'),
            type: $(form).attr('method'),
            data: formData,
            contentType: false,
            processData: false,
            beforeSend: function () {

            },
            success: function (response) {
                $('.overlay-spinner').css('display', 'none');
                $(".MenuCardsSection").html(response);
            }
        });
    }

}
function FormValidation()
{
    return CityValidation();
}
function CityValidation() {
    if ($("#CityId").val() == null) {

        swal({
            //text: "Your webinar was added to your cart successfully.",
            icon: 'error',
            title: "Please Select a city",
        });
        return false;
    } else {

        return true;
    }
}
