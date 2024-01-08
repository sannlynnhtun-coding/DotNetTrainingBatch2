const tblName = "Tbl_Name";
$('#btnSave').click(function () {
    let lst = [];
    if (localStorage.getItem(tblName) != null) {
        lst = JSON.parse(localStorage.getItem(tblName));
        console.log({ lst });
    }

    const name = $('#txtName').val();
    const data = {
        Id : uuidv4(),
        Name: name
    };
    lst.push(data);
    console.log({ lst });
    localStorage.setItem(tblName, JSON.stringify(lst));
})

function uuidv4() {
  return "10000000-1000-4000-8000-100000000000".replace(/[018]/g, c =>
    (c ^ crypto.getRandomValues(new Uint8Array(1))[0] & 15 >> c / 4).toString(16)
  );
}