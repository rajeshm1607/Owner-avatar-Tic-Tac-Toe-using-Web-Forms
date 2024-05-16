<%@ Application Language="C#" %>
<%@ Import Namespace="ASP_HW_2" %>
<%@ Import Namespace="System.Web.Optimization" %>
<%@ Import Namespace="System.Web.Routing" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        RouteConfig.RegisterRoutes(RouteTable.Routes);
        BundleConfig.RegisterBundles(BundleTable.Bundles);
        Application["UsernameList"] = new Dictionary<string, string>();
    }

</script>
