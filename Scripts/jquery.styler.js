$(function () {
    if (supports_html5_storage) {
        if (sessionStorage.Base) {
            changeBase();
        }
        else {
            sessionStorage.Base = "dark";
        }

        if (sessionStorage.Highlight) {
            changeHighlight();
        }
        else {
            sessionStorage.Highlight = "red";
        }
    }

    $('.skin-chooser-toggle').click(function () {
        $('.skin-chooser-wrap').toggleClass('show');
    });

    $('.base').on('click', function (e) {
        if (supports_html5_storage) {
            sessionStorage.Base = $(this).attr('id');

            changeBase();
        }
        else {
            alert('Your browser does not support HTML5 Session Storage');
        }
    });

    $('.highlight').on('click', function (e) {
        if (supports_html5_storage) {
            sessionStorage.Highlight = $(this).attr('id');

            changeHighlight();
        }
        else {
            alert('Your browser does not support HTML5 Session Storage');
        }
    });
});

function supports_html5_storage() {
    try {
        return 'localStorage' in window && window['localStorage'] !== null;
    }
    catch (e) {
        return false;
    }
}

function changeBase() {
    $('link[rel=stylesheet][href="/Themes/PJS.FlatJack/Styles/skins/dark-blue.css"]').remove();
    $('link[rel=stylesheet][href="/Themes/PJS.FlatJack/Styles/skins/dark-green-alt.css"]').remove();
    $('link[rel=stylesheet][href="/Themes/PJS.FlatJack/Styles/skins/dark-green.css"]').remove();
    $('link[rel=stylesheet][href="/Themes/PJS.FlatJack/Styles/skins/dark-purple.css"]').remove();
    $('link[rel=stylesheet][href="/Themes/PJS.FlatJack/Styles/skins/dark-red.css"]').remove();
    $('link[rel=stylesheet][href="/Themes/PJS.FlatJack/Styles/skins/light-blue.css"]').remove();
    $('link[rel=stylesheet][href="/Themes/PJS.FlatJack/Styles/skins/light-green-alt.css"]').remove();
    $('link[rel=stylesheet][href="/Themes/PJS.FlatJack/Styles/skins/light-green.css"]').remove();
    $('link[rel=stylesheet][href="/Themes/PJS.FlatJack/Styles/skins/light-purple.css"]').remove();
    $('link[rel=stylesheet][href="/Themes/PJS.FlatJack/Styles/skins/light-red.css"]').remove();

    $('body').removeClass(function (index, css) {
        return (css.match(/\bbase-\S+/g) || []).join(' ');
    });

    var fileref = document.createElement("link");
    fileref.setAttribute("rel", "stylesheet");
    fileref.setAttribute("type", "text/css");
    fileref.setAttribute("href", "/Themes/PJS.FlatJack/Styles/skins/" + sessionStorage.Base + "-" + sessionStorage.Highlight + ".css");
    document.getElementsByTagName("head")[0].appendChild(fileref);

    $('body').addClass(sessionStorage.Base);

    if (sessionStorage.Base == 'dark') {
        $('#branding-logo img').attr('src', window.applicationBaseUrl + '/Themes/PJS.FlatJack/Content/logo.png');
        $('#theme-name img').attr('src', window.applicationBaseUrl + '/Themes/PJS.FlatJack/Content/logo.png');
    }
    else {
        $('#branding-logo img').attr('src', window.applicationBaseUrl + '/Themes/PJS.FlatJack/Content/light-logo.png');
        $('#theme-name img').attr('src', window.applicationBaseUrl + '/Themes/PJS.FlatJack/Content/light-logo.png');
    }

    $('.base').removeClass('active');
    $('#' + sessionStorage.Base).addClass('active');
}

function changeHighlight() {
    $('link[rel=stylesheet][href="/Themes/PJS.FlatJack/Styles/skins/dark-blue.css"]').remove();
    $('link[rel=stylesheet][href="/Themes/PJS.FlatJack/Styles/skins/dark-green-alt.css"]').remove();
    $('link[rel=stylesheet][href="/Themes/PJS.FlatJack/Styles/skins/dark-green.css"]').remove();
    $('link[rel=stylesheet][href="/Themes/PJS.FlatJack/Styles/skins/dark-purple.css"]').remove();
    $('link[rel=stylesheet][href="/Themes/PJS.FlatJack/Styles/skins/dark-red.css"]').remove();
    $('link[rel=stylesheet][href="/Themes/PJS.FlatJack/Styles/skins/light-blue.css"]').remove();
    $('link[rel=stylesheet][href="/Themes/PJS.FlatJack/Styles/skins/light-green-alt.css"]').remove();
    $('link[rel=stylesheet][href="/Themes/PJS.FlatJack/Styles/skins/light-green.css"]').remove();
    $('link[rel=stylesheet][href="/Themes/PJS.FlatJack/Styles/skins/light-purple.css"]').remove();
    $('link[rel=stylesheet][href="/Themes/PJS.FlatJack/Styles/skins/light-red.css"]').remove();

    $('body').removeClass(function (index, css) {
        return (css.match(/\bhighlight-\S+/g) || []).join(' ');
    });

    var fileref = document.createElement("link");
    fileref.setAttribute("rel", "stylesheet");
    fileref.setAttribute("type", "text/css");
    fileref.setAttribute("href", "/Themes/PJS.FlatJack/Styles/skins/" + sessionStorage.Base + "-" + sessionStorage.Highlight + ".css");
    document.getElementsByTagName("head")[0].appendChild(fileref);

    $('body').addClass(sessionStorage.Base);

    $('.highlight').removeClass('active');
    $('#' + sessionStorage.Highlight).addClass('active');
}

function changeFixedHeader() {
    if (sessionStorage.FixedHeader == 'true') {
        $('body').addClass('fixed');
        $('.header').addClass('fixed');

        $('#fixedheader').prop('checked', true);
    }
    else {
        $('body').removeClass('fixed');
        $('.header').removeClass('fixed');

        $('#fixedheader').prop('checked', false);
    }
}