$(document).on('click', '.meniustanga', function () {
    var $this = $(this);
    $.ajax({
        url: "../../Produs/GetTricouri",
        type: "GET",
        data: { id: $this.val() },
        dataType: "html"
    }).success(function (result) {
        $('.punecontent').html(result);
        //salveaza actiuni insolvabilitate
    });
});