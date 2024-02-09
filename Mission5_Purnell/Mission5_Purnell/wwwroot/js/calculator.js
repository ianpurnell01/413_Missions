$(document).ready(function () {
    // Function to calculate and update the result
    function calculateResult() {
        var hours = $('#hours').val();
        var rate = $('#rate').val();
        var result = hours * rate;
        $('#result').val(result.toFixed(2));
    }

    // Trigger calculation on button click
    $('#calculateBtn').on('click', calculateResult);

    // Initial calculation
    calculateResult();
});