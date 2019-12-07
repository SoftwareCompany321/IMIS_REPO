function menuFletchData() {
    var subscriberListComponent = new Vue({
        el: '#menulist',
        data() {
            return {
                subscribers: [],
                isViewReady: false
            };
        },
        methods: {
            refreshData: function () {
                var self = this;
                this.isViewReady = false;
                //UPDATED TO GET DATA FROM WEB API
                axios.get('/menu/fleatchuser/')
                    .then(function (response) {
                        self.subscribers = response.data;
                        self.isViewReady = true;
                    })
                    .catch(function (error) {
                        alert("ERROR: " + (error.message | error));
                    });
            }
        },
        created: function () {
            this.refreshData();
        }
    });
}