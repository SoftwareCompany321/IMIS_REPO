$(function() {

    //pie chart

    $('#test_piechart').highcharts({
        credits: {
            enabled: false
        },
        chart: {
            plotBackgroundColor: null,
            plotBorderWidth: null,
            plotShadow: false,
            type: 'pie'
        },
        title: {
            text: ''
        },
        tooltip: {
            pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
        },

        plotOptions: {
            pie: {
                allowPointSelect: true,
                cursor: 'pointer',
                dataLabels: {
                    enabled: true,
                    format: '<b>{point.name}</b>: {point.percentage:.1f} %',
                    style: {
                        color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
                    }
                }
            }
        },

        series: [{
            name: 'People',
            colorByPoint: true,
            data: [{
                name: 'Male',
                y: 56.33
            }, {
                name: 'Female',
                y: 24.03,
                sliced: true,
                selected: true
            }, {
                name: 'Others',
                y: 10.38

            }]
        }]
    });


    //Bar chart
    $('#test_barchart').highcharts({
        credits: {
            enabled: false
        },
        chart: {
            type: 'column'
        },
        title: {
            text: ""
        },

        yAxis: [{
            min: 0,
            title: {
                text: 'Household count'
            }
        }, {
            title: {
                text: 'Count (millions)'
            },
            opposite: true
        }],
        legend: {
            shadow: false
        },
        tooltip: {
            shared: true
        },
        plotOptions: {
            column: {
                grouping: false,
                shadow: false,
                borderWidth: 0
            }
        },
        series: [{
            name: 'Literacy (M)',
            color: 'rgba(165,170,217,1)',
            data: [150, 73, 20],
            pointPadding: 0.3,
            pointPlacement: -0.2
        }, {
            name: 'Literacy (F)',
            color: 'rgba(126,86,134,.9)',
            data: [140, 90, 40],
            pointPadding: 0.4,
            pointPlacement: -0.2
        }, {
            name: 'Disability(M)',
            color: 'rgba(248,161,63,1)',
            data: [183.6, 178.8, 198.5],
            tooltip: {

                valueSuffix: ' M'
            },
            pointPadding: 0.3,
            pointPlacement: 0.2,
            yAxis: 1
        }, {
            name: 'Disability(F)',
            color: 'rgba(186,60,61,.9)',
            data: [203.6, 198.8, 208.5],
            tooltip: {

                valueSuffix: ' M'
            },
            pointPadding: 0.4,
            pointPlacement: 0.2,
            yAxis: 1
        }]
    });

    //Donut

    $('#test_donut').highcharts({
        credits: {
            enabled: false
        },
        chart: {
            type: 'pie',
            options3d: {
                enabled: true,
                alpha: 45
            }
        },
        title: {
            text: ''
        },
        subtitle: {
            text: ''
        },
        plotOptions: {
            pie: {

                innerSize: 100,
                depth: 45,
                dataLabels: {
                    enabled: true
                }
            }
        },
        series: [{
            name: 'No. in millions',
            data: [
                ['College', 8],
                ['Literacy Programme', 3],
                ['Pre -School', 1],
                ['Primary', 6],
                ['Sec/High School', 8],
                ['University    ', 4],
                ['Vocational', 4],
                ['None)', 1],
            ]
        }]
    });

    // Line chart
    $('#testlinechart').highcharts({
        chart: {
            type: 'area',
            spacingBottom: 30
        },
        title: {
            text: ''
        },
        subtitle: {
            text: '* ',
            floating: true,
            align: 'right',
            verticalAlign: 'bottom',
            y: 15
        },
        legend: {
            layout: 'vertical',
            align: 'left',
            verticalAlign: 'top',
            x: 150,
            y: 100,
            floating: true,
            borderWidth: 1,
            backgroundColor: (Highcharts.theme && Highcharts.theme.legendBackgroundColor) || '#FFFFFF'
        },
        xAxis: {
            categories: ['Shiselweni', 'Hhohho', 'Manzini', 'Lubombo','Shiselweni', 'Hhohho', 'Manzini', 'Lubombo']
        },
        yAxis: {
            title: {
                text: 'Y-Axis'
            },
            labels: {
                formatter: function() {
                    return this.value;
                }
            }
        },
        tooltip: {
            formatter: function() {
                return '<b>' + this.series.name + '</b><br/>' +
                    this.x + ': ' + this.y;
            }
        },
        plotOptions: {
            area: {
                fillOpacity: 0.5
            }
        },
        credits: {
            enabled: false
        },
        series: [{
            name: 'Male',
            data: [0, 1, 4, 4, 5, 2, 3, 7]
        }, {
            name: 'Female',
            data: [1, 0, 3, null, 3, 1, 2, 1]
        }]
    });



});
