$(document).ready(function(){
    $('#viewkanji').fadeOut('slow').load('Home/BoxKanji');
    refresh();
});
function refresh()
{
    setTimeout(function () {
        $('#viewkanji').fadeOut('slow').load('Home/BoxKanji').fadeIn('slow');
        refresh();},1000);
}