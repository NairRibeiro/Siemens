$(document).ready(function () {
        var date = new Date($('#date-input').val());
        var anoB = false;
        day = date.getDate();
        month = date.getMonth() + 1;
        year = date.getFullYear();


    $('#submit').click(function () {
        
        //alert([day, month, year].join('/'));

        if (year % 4 == 0)
        {
            anoB = true;
        } else if (year % 100 == 0)
        {
            anoB = false;
        } else if (year % 400 == 0)
        {
            anoB = true;
        }

        switch (month == 1 & month == 3 & month == 5 & month == 7 & month == 8 & month == 10)
        {
            case 1:
                if (day < 31) {
                    day = day + 1;
                }
                break;
            case 2:
                if (day == 31) {
                    day = 1;
                    month = month + 1;
                }
                break;
            default:
                break;
        }

        switch (month == 4 & month == 6 & month == 9 & month == 11) {
            case 1:
                if (day < 31) {
                    day = day + 1;
                }
                break;
            case 2:
                if (day == 31) {
                    day = 1;
                    month = month + 1;
                }
                break;
            default:
                break;
        }

        switch (month == 12) {
            case 1:
                if (day < 31) {
                    day = day + 1;
                }
                break;
            case 2:
                if (day == 31) {
                    day = 1;
                    month = 1;
                    year = year + 1;
                }
                break;
            default:
                break;
        }

        switch (month == 2 & anoB == true) {
            case 1:
                if (day < 29) {
                    day = day + 1;
                }
                
                break;
            case 2:
                if (day == 29) {
                    day = 1;
                    month = month + 1;
                }
                break;
            default:
                break;
        }

        switch (month == 2 & anoB == false) {
            case 1:
                if (day < 28) {
                    day = day + 1;
                }

                break;
            case 2:
                if (day == 28) {
                    day = 1;
                    month = month + 1;
                }
                break;
            default:
                break;
        }

        alert([day, month, year].join('/'));
    });
       
});
