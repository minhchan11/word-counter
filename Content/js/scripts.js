$(document).ready(function() {
  // Prevent number and special characters
  $('input').keypress(function(key) {
    if (key.charCode == 32 || key.charCode == 13)
    {
      return true;
    }
    else if( (key.charCode < 97 || key.charCode > 122) && (key.charCode < 65 || key.charCode > 90) && (key.charCode != 45))
    { alert("Please don't enter number or special characters");
      return false; } ;
  });
  //prevent space, make sure only 1 word is entered
  $("input#word").on("keydown", function (e) {
  return e.which !== 32;
  });

  $("form").submit(function(event) {
    if($("input#word").val() == "")
    {
      alert("Please put in a word");
      event.preventDefault();
    }
    else if($("input#sentence").val() == "")
    {
      alert("Please put in a sentence");
      event.preventDefault();
    }
    else {
      $(".pageOne").fadeOut(1000);
      $(".pageTwo").delay("slow").fadeIn();
    }
  });
});
