// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function loadData(adr) {
    $('.loader').show();
    $.getJSON(adr).done(function (data) {
        processData(data);
    }).fail(function (err) {
        alert('err')
    }).always(function () {
        $('.loader').hide();
    });
}

function processData(data) {
    if (data.length === 0) {
        $('#empty').show();
        $('#datatable').hide();
    } else {
        $('#empty').hide();
        $('#datatable').show();
        $('#rbody').empty();
        for (var i = 0; i < data.length; i++) {
            var row = data[i];
            const tag = '<tr><td><strong>' + row.number + '</strong></td><td>' +
                row.name + '</td><td>' + row.address + '</td></tr>';

            $(tag).appendTo('#rbody');
        }
    }
}

$(function () {
    $('#empty').hide();
    $('#datatable').hide();
    $('.loader').hide();
    loadData('/api/entity');
    $('#txtFiltrer').on('input', function (v) {
        var val = $(this).val();
        if (val == '') {
            loadData('/api/entity');
        } else {
            const addr = '/api/entity/find/' + val;
            loadData(addr);
        }
    });

});