﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEnt
{
    public partial class İletisim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVEntities db = new DBCVEntities();
            var mesaj = db.TBLILETISIM.ToList();
            Repeater1.DataSource = mesaj;
            Repeater1.DataBind();

        }
    }
}