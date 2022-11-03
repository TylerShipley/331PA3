let drivers = [];
const baseUrl = "https://localhost:7159/api/";
const body = document.getElementById('root');
let table = document.createElement('table');
table.className = 'table';
let thead = document.createElement('thead');
table.appendChild(thead);

function handleOnLoad() {
    getDrivers();
    createHeader();
    createBody();
}

function getDrivers() {
    const getDriversUrl = baseUrl + 'Driver';
    fetch(getDriversUrl, {
        method: "GET",
        headers: {'Content-Type': 'application/json'}
    })
    .then(response => {
        return response.json();
    })
    .then(driver => {
        addDrivers(driver);
    })

}



function addDrivers(driversJson) {
    driversJson.forEach(driver => {
        drivers.push(driver);
    })
    console.log(drivers);
}



function createHeader() {
    let tr = document.createElement('tr');
    let array = ['ID','Name', 'DateHired', 'Rating', 'Active'];

    array.forEach((heading) => {
        let th = document.createElement('th');
        th.append(document.createTextNode(heading));
        tr.appendChild(th);
    })
    thead.appendChild(tr);
    body.appendChild(table);
}

function createBody() {
        drivers.forEach((driver) => {
        let tr = document.createElement('tr');

        let idTd = document.createElement('td');
        idTd.appendChild(document.createTextNode(`{driver.Id}`));
        tr.appendChild(idTd);

        let NameTd = document.createElement('td');
        NameTd.appendChild(document.createTextNode(`{driver.Name}`));
        tr.appendChild(NameTd);

        let DateHiredTd = document.createElement('td');
        DateHiredTd.appendChild(document.createTextNode(`{driver.DateHired}`));
        tr.appendChild(DateHiredTd);

        let RatingTd = document.createElement('td');
        let userRating = document.createElement('input');
        userRating.type = 'text';
        userRating.defaultValue = 0;
        userRating.addEventListener('change', function(e) {
            console.log(parseInt(e.target.value, 10));

        let ActiveTd = document.createElement('td');
        ActiveTd.appendChild(document.createTextNode(`{driver.Active}`));
        tr.appendChild(ActiveTd);
        })
        RatingTd.appendChild(userRating);
        tr.appendChild(RatingTd);
        table.appendChild(tr);
        
    })
}