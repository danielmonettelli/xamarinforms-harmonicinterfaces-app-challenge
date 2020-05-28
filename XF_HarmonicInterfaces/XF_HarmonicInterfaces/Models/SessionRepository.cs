using System;
using System.Collections.Generic;
using System.Text;

namespace XF_HarmonicInterfaces.Models
{
    public static class SessionRepository
    {
        static SessionRepository()
        {
            if (Sessions == null)
            {
                Sessions = new List<Session>
                {
                    new Session
                    {
                        Id_Session=Guid.Parse("{97D0AA07-023A-4152-8440-3E0EC10313E1}"),
                        Name_Session="Session 01",
                        Image_Session="resource://XF_HarmonicInterfaces.SVGImages.svg_play1.svg"
                    },
                    new Session
                    {
                        Id_Session=Guid.Parse("{7C572016-4EE4-4E47-B81D-427EBD5FE876}"),
                        Name_Session="Session 02",
                        Image_Session="resource://XF_HarmonicInterfaces.SVGImages.svg_play2.svg"
                    },
                    new Session
                    {
                        Id_Session=Guid.Parse("{A90390E8-E88E-4713-BEAA-AA3933CE8987}"),
                        Name_Session="Session 03",
                        Image_Session="resource://XF_HarmonicInterfaces.SVGImages.svg_play2.svg"
                    },
                    new Session
                    {
                        Id_Session=Guid.Parse("{0864D365-0456-48F8-9526-C87770F229E6}"),
                        Name_Session="Session 04",
                        Image_Session="resource://XF_HarmonicInterfaces.SVGImages.svg_play2.svg"
                    },
                    new Session
                    {
                        Id_Session=Guid.Parse("{B54BA5E4-0104-47B9-B156-3B0153860E4B}"),
                        Name_Session="Session 05",
                        Image_Session="resource://XF_HarmonicInterfaces.SVGImages.svg_play2.svg"
                    },
                    new Session
                    {
                        Id_Session=Guid.Parse("{B9F49E5A-25F8-4713-8710-0A72C28933F9}"),
                        Name_Session="Session 06",
                        Image_Session="resource://XF_HarmonicInterfaces.SVGImages.svg_play2.svg"
                    },
                };
            }
        }

        public static List<Session> Sessions { get; set; }
    }
}
