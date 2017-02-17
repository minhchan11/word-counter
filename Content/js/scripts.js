$(document).ready(function() {
  $("#button").submit(function(event) {
    event.preventDefault();
    if($("input#word").val() == "")
    {
      alert("Please put in a word");
    }
    else if($("input#sentence").val() == "")
    {
      alert("Please put in a sentence");
    }
    // else {
    //   // $(".pageOne").fadeOut(1000);
    //   // $(".pageTwo").fadeIn(1000).removeClass("noShow");
    // }
  });
});
