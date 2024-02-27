const getLocationData = async () => {
    await fetch('http://localhost:4914/PersonLocations')
        .then(response => response.json())
        .then(data => {
            let dataSkud = data.response;
            let type;
            for (let i = 0; i < 21; i++) {
                const skudData = dataSkud.filter(item => item.lastSecurityPointNumber === i
                    && item.lastSecurityPointDirection == "in" && item.personRole == "Клиент");
                let html = skudData.map(item => `<div class="client"></div>`).join('');
                document.querySelector(`.skud${i}`).innerHTML = html;

                const skudDataEmp = dataSkud.filter(item => item.lastSecurityPointNumber === i
                    && item.lastSecurityPointDirection == "in" && item.personRole == "Сотрудник");
                let htmlEmp = skudDataEmp.map(item => `<div class="employee"></div>`).join('');
                document.querySelector(`.skud${i}`).innerHTML += htmlEmp;
            }


        })
        .catch(error => {
            console.error('Произошла ошибка при получении данных:', error);
        });
}

/*setInterval(getLocationData, 3000);*/

const getDepartmentData = async () => {
    await fetch('https://localhost:7053/api/departaments/api/departaments/getall')
        .then(responce => responce.json())
        .then(data => {
            const filteredData = data.filter(item => item.departmentId === 1);
            let html = filteredData.map(item => `<div class="client"></div>`).join('');
            document.querySelector(`.dep104`).innerHTML = html;
        });
}

getDepartmentData()