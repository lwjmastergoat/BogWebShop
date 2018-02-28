

var ctx = document.getElementById('myChart3').getContext('2d');
var chart = new Chart(ctx, {
    // The type of chart we want to create
    type: 'pie',

    // The data for our dataset
    data: {
        labels: [
            'Mænd',
            'Intetkøn',
            'Kvinder'
        ],
        datasets: [{
            backgroundColor: ['rgb(79, 149, 255)', 'rgb(1, 196, 66)', 'rgb(255, 102, 178)'],
            data: [65, 5, 30]
        }],
    },

    // Configuration options go here
    options: {}
});