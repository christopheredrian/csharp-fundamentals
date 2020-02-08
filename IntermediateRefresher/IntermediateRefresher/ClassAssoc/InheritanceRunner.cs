using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediateRefresher.ClassAssoc
{

    class InheritanceRunner
    {

        public static void Run()
        {
            //var text = new Text();
            //text.Width = 100;

            //text.Copy();

            var dbMigrator = new DBMigrator(new Logger());
            dbMigrator.Migrate();

            var installer = new Installer(new Logger());
            installer.Install();

        }

    }
}
