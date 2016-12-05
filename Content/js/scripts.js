$(document).ready(function(){
  $(".container").delay(250);
  $(".container").fadeIn();
  $("#send-words").click(function(){
    console.log("click");
    $(".container").slideUp({complete : function() {$("form#word-form").submit()}});
  });
});