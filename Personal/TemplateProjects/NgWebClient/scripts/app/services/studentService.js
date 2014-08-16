app.service('studentService', ['studentFactory',
    function (Student) {

        this.students = null;

        this.search = function() {
            if (this.searchCriteria == null) {
                this.searchCriteria = new SearchCriteria();
            }

            if (this.students != null) {
                return this.students;
            }
            return Student.query(this.searchCriteria);
        };

        this.processData = function (data) {
            this.students = [];
            this.students = data;
            return this.students;
        };
    }
]);



