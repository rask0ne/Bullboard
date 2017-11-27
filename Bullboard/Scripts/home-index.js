(function($) {
    function HomeIndex() {
        var $this = this;

        function initialize() {
            $('#Description')
                .summernote({
                    focus: true,
                    height: 100,
                    codemirror: {
                        theme: 'united'
                    }
                });
        }

        $this.init = function() {
            initialize();
        }
    }

    $(function() {
        var self = new HomeIndex();
        self.init();
    })
}(jQuery));