$(document).ready(function(){
  console.log("Document Ready");
  $(".container").delay(250);
  $(".container").fadeIn();
  console.log("Post fade in");
  $("submit").click(function(){
    $(".container").fadeOut();  
  });
});