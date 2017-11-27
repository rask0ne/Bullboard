var searchAction = function() {
    $("#search-field,#min-price,#max-price").keyup(function (event) {
        if (event.keyCode === 13) {
            search(event);
        }
    });
}

var searchStringHandler = function () {
    $("#search-field").keyup(function (event) {
        if (event.keyCode === 13) {
            var searchQuery = $('#search-field').val();
            $.ajax({
                type: 'POST',
                url: '/Ads/RenderAds',
                data: {"searchString": searchQuery},
                success: function (data, textstatus) {
                    if (data !== '') {
                        $("#body-id").html(data);
                    }
                    if (searchQuery !== undefined && searchQuery !== "") {
                        $('#ads-search').show();
                    } else {
                        $('#ads-search').hide();
                    }
                    $('#category').selectpicker("refresh");
                    $('#subcategory').selectpicker("refresh");
                    $('#type').selectpicker("refresh");
                }
            });
        }
    });
}

var search = function (event) {

    var searchQuery = $('#search-field').val();
    var minPriceQuery = $('#min-price').val();
    var maxPriceQuery = $('#max-price').val();
    var typeQuery = $('#type').val();
    var categoryQuery = $('#category').val();
    var subCategoryQuery = $('#subcategory').val();

    if (typeQuery === "Sale" && searchQuery !== undefined) {
        $('#min-price').show();
        $('#max-price').show();
    } else {
        $('#min-price').hide();
        $('#max-price').hide();
    }

    $.ajax({
        type: 'POST',
        url: '/Ads/UpdateAds',
        data: {
            "searchString": searchQuery, "minPrice": minPriceQuery, "maxPrice": maxPriceQuery,
            "type": typeQuery, "category": categoryQuery, "subCategory": subCategoryQuery
        },
        success: function (data, textstatus) {
            if (data !== '') {
                $("#body-content").html(data);
                if (typeQuery === "Sale") {
                    $('#price-search').show();
                } else {
                    $('#price-search').hide();
                }
                $('#category').selectpicker("refresh");
                $('#subcategory').selectpicker("refresh");
                $('#type').selectpicker("refresh");
            }
        }
    });
}

var getSubCategoriesCreate = function(event) {
    var categoryQuery = $('#category-create-or-update').val();
    $.ajax({
        type: 'POST',
        url: '/SubCategories/GetSubCategories',
        data: { "categoryName": categoryQuery },
        success: function (data, textstatus) {
            var target = $('#subcategory-create-or-update').selectpicker();
            target.empty();
            for (var i = 0; i < data.length; i++) {
                var newitemnum = i;
                var newitemdesc = data[i].Name;
                target.append('<option value="' + newitemdesc + '" selected="">' + newitemdesc + '</option>');
                target.selectpicker("refresh");
            }
        }
    });
}

var getSubCategories = function (event) {
    var categoryQuery = $('#category').val();
    $.ajax({
        type: 'POST',
        url: '/SubCategories/GetSubCategories',
        data: { "categoryName": categoryQuery },
        success: function (data, textstatus) {
            var target = $('#subcategory').selectpicker();
            target.empty();
            console.log(categoryQuery + data.length);
            for (var i = data.length - 1; i >= 0; i--) {
                var newitemnum = i;
                var newitemdesc = data[i].Name;
                target.append('<option>' + newitemdesc + '</option>');
                target.selectpicker("refresh");
            }
        }
    });
}