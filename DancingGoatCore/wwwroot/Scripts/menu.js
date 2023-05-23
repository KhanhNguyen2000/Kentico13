const btnToggle = document.querySelector(".btn-toggle")
const btnExit = document.querySelector(".btn-exit")
const listMenu = document.querySelector(".page-menu")

btnToggle.addEventListener("click", (e) => {
    listMenu.style.display = listMenu.style.display == "block" ? "none" : "block";
    btnExit.style.display = "flex";
    btnToggle.style.display = "none";
})

btnExit.addEventListener("click", (e) => {
    listMenu.style.display = listMenu.style.display == "block" ? "none" : "block";
    btnToggle.style.display = "flex";
    btnExit.style.display = "none";
})

document.addEventListener('click', function (event) {
    var isClickInside = btnToggle.contains(event.target);
    var isClickInsideMenu = listMenu.contains(event.target);
    if (isClickInside || isClickInsideMenu) {
        console.log('Clicked INSIDE element')
    }
    else {
        listMenu.style.display = "none";
        btnToggle.style.display = "flex";
        btnExit.style.display = "none";
        console.log('Clicked OUTSIDE element')
    }
});

const btnkhcn = document.querySelector(".btn-khcn")
const btnkhdn = document.querySelector(".btn-khdn")
const menuCustomerPersonal = document.querySelector(".menu-customer-personal")
const menuCustomerBusiness = document.querySelector(".menu-customer-business")

btnkhdn.addEventListener("click", (e) => {
    btnkhdn.style.background = "#005D98";
    btnkhdn.style.color = "#ffffff";
    btnkhcn.style.background = "#ffffff";
    btnkhcn.style.color = "black";
    menuCustomerPersonal.style.display = "none";
    menuCustomerBusiness.style.display = "flex";
})

btnkhcn.addEventListener("click", (e) => {
    btnkhcn.style.background = "#005D98";
    btnkhdn.style.color = "black";
    btnkhdn.style.background = "#ffffff";
    btnkhcn.style.color = "#ffffff";
    menuCustomerPersonal.style.display = "flex";
    menuCustomerBusiness.style.display = "none";
})

