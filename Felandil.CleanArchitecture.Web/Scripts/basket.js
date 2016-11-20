$(document).ready(function(e) {
    var $addArticleButton = $('#btnAddArticle');

    $addArticleButton.click(function () {
        var $quantity = $('#art-quantity')[0];
        var $price = $('#art-price')[0];

        $.post("/Home/AddArticle", { "quantity": $quantity.value, "price": $price.value }, function (data) {
            $('#basket-articlecount')[0].innerHTML = data.ArticleCount;
            $('#basket-value')[0].innerHTML = data.BasketValue;

            $quantity.value = "";
            $price.value = "";
        });
    });
});