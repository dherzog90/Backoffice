﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice
{
    public class Rechnung
    {
        int rechnungid;
        string bezeichnung;
        DateTime? datum;
        int? projektid;
        int kundenid;
        ObjectStates status;

        public Rechnung()
        {
            this.datum = DateTime.Today;
            this.rechnungid = 0;
            this.bezeichnung = string.Empty;
            this.projektid = 0;
            this.kundenid = 0;
        }

        public Rechnung(int rechnungid, string bezeichnung, DateTime datum, int projektid, int kundenid, ObjectStates status)
        {
            this.rechnungid = rechnungid;
            this.bezeichnung = bezeichnung;
            this.datum = datum;
            this.projektid = projektid;
            this.kundenid = kundenid;
            this.status = status;
        }

        public int Rechnungid
        {
            get { return rechnungid; }
            set
            {
                if (rechnungid != value)
                {
                    rechnungid = value;
                    status = ObjectStates.Modified;
                }
            }
        }

        public string Bezeichnung
        {
            get { return bezeichnung; }
            set
            {
                if (!bezeichnung.Equals(value))
                {
                    bezeichnung = value;
                    status = ObjectStates.Modified;
                }
            }
        }

        public DateTime? Datum
        {
            get { return datum; }
            set 
            { 
                if (datum.Equals(value))
                { 
                    datum = value;
                    status = ObjectStates.Modified;
                }
            }
        }

        public int? Projektid
        {
            get { return projektid; }
            set
            {
                if (projektid != value)
                {
                    projektid = value;
                    status = ObjectStates.Modified;
                }
            }
        }

        public int Kundenid
        {
            get { return kundenid; }
            set
            {
                if (kundenid != value)
                {
                    kundenid = value;
                    status = ObjectStates.Modified;
                }
            }
        }

        public ObjectStates Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
