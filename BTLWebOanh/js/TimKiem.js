function checksearchForm() {
    var timkiem = document.getElementById("keysearch").value;
    if (timkiem.length>0) {
        return true;
    }
    alert("Nhập từ khóa tìm kiếm");
    console.log(timkiem);
    return false;
}