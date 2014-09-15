$(function () {
    //BREADCRUMBS
    $('.breadcrumb > li.current > a').contents().unwrap();

    //PAGINATION
    $('#pagination ul').removeClass('pager').addClass('pagination');
});