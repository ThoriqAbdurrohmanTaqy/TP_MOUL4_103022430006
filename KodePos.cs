using System;
using System.Collections.Generic;

namespace TP_MODUL4_103022430006
{
    public class KodePos
    {
        private Dictionary<string, int> tabel = new Dictionary<string, int>()
        {
            {"Batununggal", 40266}, {"Kujangsari", 40287}, {"Mengger", 40267}
            // Tambahkan kelurahan lainnya di sini...
        };

        public int getKodePos(string kelurahan)
        {
            return tabel.ContainsKey(kelurahan) ? tabel[kelurahan] : -1;
        }
    }
}