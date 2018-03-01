

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
            backgroundColor: ['rgb(53, 101, 173)', 'rgb(0, 150, 50)', 'rgb(198, 75, 75)'],
            data: [65, 5, 30]
        }],
    },

    // Configuration options go here
    options: {}
});