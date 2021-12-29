const BASE_URL = 'https://localhost:7114/';


function saveMark(caller) {
    let data = {
        "studentId": $(caller).attr('student-id'),
        "teacherId": $(caller).attr('teacher-id'),
        "pairId": $(caller).attr('pair-id'),
        "grade": $(caller).val()
    }

    $.ajax({
            type: "POST",
            url: BASE_URL + 'marks/save',
            headers: {
                "Content-Type": "application/json"
            },
            data: JSON.stringify(data),
            success: function () {
                alert('Entity added!');
            },
            error: function (e) {
                alert(JSON.stringify(e));
            }
        }
    )
} 

function showAddStudentModal() {
    $('#add-student-modal').removeClass('visually-hidden');
}

function addStudent() {
    $('#add-student-modal').addClass('visually-hidden');
    
    const data = {
        group: null,
        groupid: $('#title-h2').attr('group-id'),
        firstname: $('#student-first-name').val(),
        lastname: $('#student-last-name').val(),
        from: 0
    }

    $.ajax({
            type: "POST",
            url: BASE_URL + 'students/add',
            headers: {
                "Content-Type": "application/json"
            },
            data: JSON.stringify(data),
            success: function () {
                alert('Entity added!');
            },
            error: function (e) {
                alert(JSON.stringify(e));
            }
        }
    )
}

function addPairModal(subjectId) {
    const data = {
        subjectid: subjectId,
        marks: []
    }

    $.ajax({
            type: "POST",
            url: BASE_URL + 'pairs/add',
            headers: {
                "Content-Type": "application/json"
            },
            data: JSON.stringify(data),
            success: function () {
                window.reload();
            },
            error: function (e) {
                alert(JSON.stringify(e));
            }
        }
    )
}