var ct1 = document.getElementById('myChart2').getContext('2d');
var chart = new Chart(ct1, {
    // The type of chart we want to create
    type: 'bar',

    // The data for our dataset
    data: {
        labels: ["September", "Oktober", "November", "December", "Januar", "Februar", "Marts"],
        datasets: [{
            label: "Produkt visninger",
            backgroundColor: 'rgb(79, 163, 99)',
            borderColor: 'rgb(77, 77, 77)',
            data: [2100, 1923, 3214, 6412, 3100, 8491, 320],
        }]

    },

    // Configuration options go here
    options: {}
});