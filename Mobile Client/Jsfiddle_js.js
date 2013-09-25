var echo = function(dataPass) {
    $.ajax({
        type: "POST",
        url: "/echo/json/",
        data: dataPass,
        cache: false,
        success: function(json) {
            alert("Operation="+json.Operation+"\nResult="+json.Output);
        }
    });
};
$('.add').live('click', function() {
   var url="http://vhost0889.site1.compute.ihost.com/aspnet_client/restful/Service1.svc/add/"+document.getElementById('v1').value+"/"+document.getElementById('v2').value ;
   
   $.get(url, function(data) {
        var json = {
            json: JSON.stringify(data),
            delay: 1
        };
        echo(json);
    });
});
$('.sub').live('click', function() {
   var url="http://vhost0889.site1.compute.ihost.com/aspnet_client/restful/Service1.svc/sub/"+document.getElementById('v1').value+"/"+document.getElementById('v2').value ;
   
   $.get(url, function(data) {
        var json = {
            json: JSON.stringify(data),
            delay: 1
        };
        echo(json);
    });
});
$('.mul').live('click', function() {
   var url="http://vhost0889.site1.compute.ihost.com/aspnet_client/restful/Service1.svc/mul/"+document.getElementById('v1').value+"/"+document.getElementById('v2').value ;
   
   $.get(url, function(data) {
        var json = {
            json: JSON.stringify(data),
            delay: 1
        };
        echo(json);
    });
});
$('.divi').live('click', function() {
   var url="http://vhost0889.site1.compute.ihost.com/aspnet_client/restful/Service1.svc/div/"+document.getElementById('v1').value+"/"+document.getElementById('v2').value ;
   
   $.get(url, function(data) {
        var json = {
            json: JSON.stringify(data),
            delay: 1
        };
        echo(json);
    });
});
