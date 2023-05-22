const btnMenu = document.querySelector(".btn-menu")
const listMenu = document.querySelector(".page-menu")
console.log(btnMenu)
btnMenu.addEventListener("click", (e) => {

    listMenu.style.display = listMenu.style.display =="block" ? "none" : "block";
    
    console.log({ listMenu })
})

const btnkhcn = document.querySelector(".btn-khcn")
const btnkhdn = document.querySelector(".btn-khdn")

btnkhdn.addEventListener("click", (e) => {
    console.log({btnkhdn})
    btnkhdn.style.background = "#005D98";
    btnkhdn.style.color = "#ffffff";
    btnkhcn.style.background = "#ffffff";
    btnkhcn.style.color = "black";
})

btnkhcn.addEventListener("click", (e) => {
    console.log({ btnkhdn })
    btnkhcn.style.background = "#005D98";
    btnkhdn.style.color = "black";
    btnkhdn.style.background = "#ffffff";
    btnkhcn.style.color = "#ffffff";
})