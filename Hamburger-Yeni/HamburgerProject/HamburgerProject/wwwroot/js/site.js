// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function AddProductToBasket(id, Quantity) {
    let addData = {
        productId: id,
        quantity: Quantity
    }
    $.ajax(
        {
            url: "/Order/AddBasket",
            type: "GET",
            data: addData,

            success: function (response) {
                $('#order-basket').html(response);
                $('#successModal').modal('show');
                $('#successModal button[data-dismiss="modal"]').click(function () {
                    $('#successModal').modal('hide');
                });
            }
        }
    )
}


function RemoveItemBasket(id) {
    let removeData = {
        ItemBasket: id,

    }
    $.ajax(
        {
            url: "/Order/RemoveBasket",
            type: "GET",
            data: removeData,

            success: function (response) {
                $("#order-basket").html(response);


            }
        }
    )
}