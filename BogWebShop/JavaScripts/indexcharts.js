﻿var ctx = document.getElementById('myChart').getContext('2d');
var chart = new Chart(ctx, {
    // The type of chart we want to create
    type: 'bar',

    // The data for our dataset
    data: {
        labels: ["September", "Oktober", "November", "December", "Januar", "Februar", "Marts"],
        datasets: [{
            label: "Produkt salg",
            backgroundColor: 'rgb(89, 89, 89)',
            borderColor: 'rgb(77, 77, 77)',
            data: [71, 61, 132, 234, 20, 421, 11],
        }]

    },

    // Configuration options go here
    options: {}
});


