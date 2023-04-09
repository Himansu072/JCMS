namespace JCMS.Web
{
    /// <summary>
    /// Content-Security-Policy-related constants.
    /// </summary>
    public static class ContentSecurityPolicyConstant
    {
        public static readonly string Header = "Content-Security-Policy";

        static string sq = "default-src 'self';script-src 'self' 'unsafe-inline' www.google-analytics.com www.googletagmanager.com; object-src 'none';style-src 'self''unsafe-inline' fonts.googleapis.com stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.3.1/css/bootstrap.min.css cdnjs.cloudflare.com/ajax/libs/mdbootstrap/4.8.8/css/mdb.min.css ;img-src 'self'  a.tile.openstreetmap.org b.tile.openstreetmap.org c.tile.openstreetmap.org www.google-analytics.com placehold.it placeholdit.imgix.net data:  ; media-src 'none';frame-src 'self' https://www.google.com/  ;font-src 'self' fonts.gstatic.com fonts.googleapis.com;connect-src 'self' ;base-uri 'self';child-src 'none';frame-ancestors 'self';";

        public static readonly string defaultsrc = sq;

    }
}
