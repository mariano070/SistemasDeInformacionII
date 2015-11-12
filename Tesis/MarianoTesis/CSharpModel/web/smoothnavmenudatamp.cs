/*
               File: SmoothNavMenuDataMP
        Description: Data Provider Menu appMP
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:17:32.85
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using GeneXus.Http.Server;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class smoothnavmenudatamp : GXProcedure
   {
      public smoothnavmenudatamp( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public smoothnavmenudatamp( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_USU_COD ,
                           short aP1_SIS_COD ,
                           int aP2_PRS_NRO ,
                           String aP3_SERVER ,
                           out IGxCollection aP4_Gxm2rootcol )
      {
         this.AV7USU_COD = aP0_USU_COD;
         this.AV6SIS_COD = aP1_SIS_COD;
         this.AV5PRS_NRO = aP2_PRS_NRO;
         this.AV11SERVER = aP3_SERVER;
         this.Gxm2rootcol = new GxObjectCollection( context, "SmoothNavMenuData.SmoothNavMenuItem", "MarianoTesis", "SdtSmoothNavMenuData_SmoothNavMenuItem", "GeneXus.Programs") ;
         initialize();
         executePrivate();
         aP4_Gxm2rootcol=this.Gxm2rootcol;
      }

      public IGxCollection executeUdp( String aP0_USU_COD ,
                                       short aP1_SIS_COD ,
                                       int aP2_PRS_NRO ,
                                       String aP3_SERVER )
      {
         this.AV7USU_COD = aP0_USU_COD;
         this.AV6SIS_COD = aP1_SIS_COD;
         this.AV5PRS_NRO = aP2_PRS_NRO;
         this.AV11SERVER = aP3_SERVER;
         this.Gxm2rootcol = new GxObjectCollection( context, "SmoothNavMenuData.SmoothNavMenuItem", "MarianoTesis", "SdtSmoothNavMenuData_SmoothNavMenuItem", "GeneXus.Programs") ;
         initialize();
         executePrivate();
         aP4_Gxm2rootcol=this.Gxm2rootcol;
         return Gxm2rootcol ;
      }

      public void executeSubmit( String aP0_USU_COD ,
                                 short aP1_SIS_COD ,
                                 int aP2_PRS_NRO ,
                                 String aP3_SERVER ,
                                 out IGxCollection aP4_Gxm2rootcol )
      {
         smoothnavmenudatamp objsmoothnavmenudatamp;
         objsmoothnavmenudatamp = new smoothnavmenudatamp();
         objsmoothnavmenudatamp.AV7USU_COD = aP0_USU_COD;
         objsmoothnavmenudatamp.AV6SIS_COD = aP1_SIS_COD;
         objsmoothnavmenudatamp.AV5PRS_NRO = aP2_PRS_NRO;
         objsmoothnavmenudatamp.AV11SERVER = aP3_SERVER;
         objsmoothnavmenudatamp.Gxm2rootcol = new GxObjectCollection( context, "SmoothNavMenuData.SmoothNavMenuItem", "MarianoTesis", "SdtSmoothNavMenuData_SmoothNavMenuItem", "GeneXus.Programs") ;
         objsmoothnavmenudatamp.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objsmoothnavmenudatamp.executePrivateCatch ));
         aP4_Gxm2rootcol=this.Gxm2rootcol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         /* Using cursor P00012 */
         pr_default.execute(0, new Object[] {AV7USU_COD, AV6SIS_COD});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A126PRG_COD = P00012_A126PRG_COD[0] ;
            A116SIS_COD = P00012_A116SIS_COD[0] ;
            A6USU_COD = P00012_A6USU_COD[0] ;
            A117PRG_WEB = P00012_A117PRG_WEB[0] ;
            A128PRG_EXT = P00012_A128PRG_EXT[0] ;
            A127PRG_DES = P00012_A127PRG_DES[0] ;
            A117PRG_WEB = P00012_A117PRG_WEB[0] ;
            A128PRG_EXT = P00012_A128PRG_EXT[0] ;
            A127PRG_DES = P00012_A127PRG_DES[0] ;
            Gxm1smoothnavmenudata = new SdtSmoothNavMenuData_SmoothNavMenuItem(context) ;
            Gxm2rootcol.Add(Gxm1smoothnavmenudata, 0);
            Gxm1smoothnavmenudata.gxTpr_Id = StringUtil.Str( (decimal)(A126PRG_COD), 4, 0) ;
            Gxm1smoothnavmenudata.gxTpr_Title = A127PRG_DES ;
            Gxm1smoothnavmenudata.gxTpr_Description = A127PRG_DES ;
            Gxm1smoothnavmenudata.gxTpr_Link = "#" ;
            /* Using cursor P00013 */
            pr_default.execute(1, new Object[] {A126PRG_COD});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A361MNU_NIV = P00013_A361MNU_NIV[0] ;
               A117PRG_WEB = P00013_A117PRG_WEB[0] ;
               A129MNU_NID = P00013_A129MNU_NID[0] ;
               A117PRG_WEB = P00013_A117PRG_WEB[0] ;
               Gxm3smoothnavmenudata_items = new SdtSmoothNavMenuData_SmoothNavMenuItem(context) ;
               Gxm1smoothnavmenudata.gxTpr_Items.Add(Gxm3smoothnavmenudata_items, 0);
               Gxm3smoothnavmenudata_items.gxTpr_Id = StringUtil.Str( (decimal)(A126PRG_COD), 4, 0) ;
               Gxm3smoothnavmenudata_items.gxTpr_Title = A129MNU_NID ;
               Gxm3smoothnavmenudata_items.gxTpr_Description = A129MNU_NID ;
               Gxm3smoothnavmenudata_items.gxTpr_Link = "#" ;
               /* Using cursor P00014 */
               pr_default.execute(2, new Object[] {A126PRG_COD, A361MNU_NIV});
               while ( (pr_default.getStatus(2) != 101) )
               {
                  A131MNU_DSN = P00014_A131MNU_DSN[0] ;
                  A132MNU_SLINK = P00014_A132MNU_SLINK[0] ;
                  A130MNU_SNI = P00014_A130MNU_SNI[0] ;
                  Gxm4smoothnavmenudata_items_items = new SdtSmoothNavMenuData_SmoothNavMenuItem(context) ;
                  Gxm3smoothnavmenudata_items.gxTpr_Items.Add(Gxm4smoothnavmenudata_items_items, 0);
                  Gxm4smoothnavmenudata_items_items.gxTpr_Id = StringUtil.Str( (decimal)(A126PRG_COD), 4, 0) ;
                  Gxm4smoothnavmenudata_items_items.gxTpr_Title = A131MNU_DSN ;
                  Gxm4smoothnavmenudata_items_items.gxTpr_Description = A131MNU_DSN ;
                  Gxm4smoothnavmenudata_items_items.gxTpr_Link = "HTTP://"+StringUtil.Trim( AV11SERVER)+"/"+StringUtil.Trim( A132MNU_SLINK)+"?"+StringUtil.Trim( StringUtil.Str( (decimal)(AV6SIS_COD), 10, 0))+","+StringUtil.Trim( AV7USU_COD)+","+StringUtil.Trim( StringUtil.Str( (decimal)(AV5PRS_NRO), 10, 0)) ;
                  AV8NOM_COOKIE = "KEY_" + StringUtil.Trim( A117PRG_WEB) + "_" + StringUtil.Trim( AV7USU_COD) ;
                  AV9A = context.SetCookie( AV8NOM_COOKIE, StringUtil.Str( (decimal)(AV5PRS_NRO), 10, 0), "", (DateTime)(DateTime.MinValue), "", 0) ;
                  AV8NOM_COOKIE = "KEY_" + StringUtil.Trim( StringUtil.Str( (decimal)(A126PRG_COD), 10, 0)) + "_" + StringUtil.Trim( AV7USU_COD) ;
                  AV9A = context.SetCookie( AV8NOM_COOKIE, StringUtil.Str( (decimal)(AV5PRS_NRO), 10, 0), "", (DateTime)(DateTime.MinValue), "", 0) ;
                  pr_default.readNext(2);
               }
               pr_default.close(2);
               pr_default.readNext(1);
            }
            pr_default.close(1);
            pr_default.readNext(0);
         }
         pr_default.close(0);
         /* Using cursor P00015 */
         pr_default.execute(3, new Object[] {AV7USU_COD, AV6SIS_COD});
         while ( (pr_default.getStatus(3) != 101) )
         {
            A126PRG_COD = P00015_A126PRG_COD[0] ;
            A116SIS_COD = P00015_A116SIS_COD[0] ;
            A6USU_COD = P00015_A6USU_COD[0] ;
            A117PRG_WEB = P00015_A117PRG_WEB[0] ;
            A128PRG_EXT = P00015_A128PRG_EXT[0] ;
            A127PRG_DES = P00015_A127PRG_DES[0] ;
            A117PRG_WEB = P00015_A117PRG_WEB[0] ;
            A128PRG_EXT = P00015_A128PRG_EXT[0] ;
            A127PRG_DES = P00015_A127PRG_DES[0] ;
            Gxm1smoothnavmenudata = new SdtSmoothNavMenuData_SmoothNavMenuItem(context) ;
            Gxm2rootcol.Add(Gxm1smoothnavmenudata, 0);
            Gxm1smoothnavmenudata.gxTpr_Id = StringUtil.Str( (decimal)(A126PRG_COD), 4, 0) ;
            Gxm1smoothnavmenudata.gxTpr_Title = A127PRG_DES ;
            Gxm1smoothnavmenudata.gxTpr_Description = A127PRG_DES ;
            Gxm1smoothnavmenudata.gxTpr_Link = "#" ;
            /* Using cursor P00016 */
            pr_default.execute(4, new Object[] {A126PRG_COD});
            while ( (pr_default.getStatus(4) != 101) )
            {
               A361MNU_NIV = P00016_A361MNU_NIV[0] ;
               A117PRG_WEB = P00016_A117PRG_WEB[0] ;
               A129MNU_NID = P00016_A129MNU_NID[0] ;
               A117PRG_WEB = P00016_A117PRG_WEB[0] ;
               Gxm3smoothnavmenudata_items = new SdtSmoothNavMenuData_SmoothNavMenuItem(context) ;
               Gxm1smoothnavmenudata.gxTpr_Items.Add(Gxm3smoothnavmenudata_items, 0);
               Gxm3smoothnavmenudata_items.gxTpr_Id = StringUtil.Str( (decimal)(A126PRG_COD), 4, 0) ;
               Gxm3smoothnavmenudata_items.gxTpr_Title = A129MNU_NID ;
               Gxm3smoothnavmenudata_items.gxTpr_Description = A129MNU_NID ;
               Gxm3smoothnavmenudata_items.gxTpr_Link = "#" ;
               /* Using cursor P00017 */
               pr_default.execute(5, new Object[] {A126PRG_COD, A361MNU_NIV});
               while ( (pr_default.getStatus(5) != 101) )
               {
                  A131MNU_DSN = P00017_A131MNU_DSN[0] ;
                  A132MNU_SLINK = P00017_A132MNU_SLINK[0] ;
                  A130MNU_SNI = P00017_A130MNU_SNI[0] ;
                  Gxm4smoothnavmenudata_items_items = new SdtSmoothNavMenuData_SmoothNavMenuItem(context) ;
                  Gxm3smoothnavmenudata_items.gxTpr_Items.Add(Gxm4smoothnavmenudata_items_items, 0);
                  Gxm4smoothnavmenudata_items_items.gxTpr_Id = StringUtil.Str( (decimal)(A126PRG_COD), 4, 0) ;
                  Gxm4smoothnavmenudata_items_items.gxTpr_Title = A131MNU_DSN ;
                  Gxm4smoothnavmenudata_items_items.gxTpr_Description = A131MNU_DSN ;
                  Gxm4smoothnavmenudata_items_items.gxTpr_Link = "HTTP://intranetamsX03/"+StringUtil.Trim( A132MNU_SLINK)+"?"+StringUtil.Trim( StringUtil.Str( (decimal)(AV6SIS_COD), 10, 0))+","+StringUtil.Trim( AV7USU_COD)+","+StringUtil.Trim( StringUtil.Str( (decimal)(AV5PRS_NRO), 10, 0)) ;
                  AV8NOM_COOKIE = "KEY_" + StringUtil.Trim( A117PRG_WEB) + "_" + StringUtil.Trim( AV7USU_COD) ;
                  AV9A = context.SetCookie( AV8NOM_COOKIE, StringUtil.Str( (decimal)(AV5PRS_NRO), 10, 0), "", (DateTime)(DateTime.MinValue), "", 0) ;
                  AV8NOM_COOKIE = "KEY_" + StringUtil.Trim( StringUtil.Str( (decimal)(A126PRG_COD), 10, 0)) + "_" + StringUtil.Trim( AV7USU_COD) ;
                  AV9A = context.SetCookie( AV8NOM_COOKIE, StringUtil.Str( (decimal)(AV5PRS_NRO), 10, 0), "", (DateTime)(DateTime.MinValue), "", 0) ;
                  pr_default.readNext(5);
               }
               pr_default.close(5);
               pr_default.readNext(4);
            }
            pr_default.close(4);
            pr_default.readNext(3);
         }
         pr_default.close(3);
         /* Using cursor P00018 */
         pr_default.execute(6, new Object[] {AV7USU_COD, AV6SIS_COD});
         while ( (pr_default.getStatus(6) != 101) )
         {
            A126PRG_COD = P00018_A126PRG_COD[0] ;
            A116SIS_COD = P00018_A116SIS_COD[0] ;
            A6USU_COD = P00018_A6USU_COD[0] ;
            A117PRG_WEB = P00018_A117PRG_WEB[0] ;
            A128PRG_EXT = P00018_A128PRG_EXT[0] ;
            A127PRG_DES = P00018_A127PRG_DES[0] ;
            A117PRG_WEB = P00018_A117PRG_WEB[0] ;
            A128PRG_EXT = P00018_A128PRG_EXT[0] ;
            A127PRG_DES = P00018_A127PRG_DES[0] ;
            Gxm1smoothnavmenudata = new SdtSmoothNavMenuData_SmoothNavMenuItem(context) ;
            Gxm2rootcol.Add(Gxm1smoothnavmenudata, 0);
            Gxm1smoothnavmenudata.gxTpr_Id = StringUtil.Str( (decimal)(A126PRG_COD), 4, 0) ;
            Gxm1smoothnavmenudata.gxTpr_Title = A127PRG_DES ;
            Gxm1smoothnavmenudata.gxTpr_Description = A127PRG_DES ;
            Gxm1smoothnavmenudata.gxTpr_Link = "#" ;
            /* Using cursor P00019 */
            pr_default.execute(7, new Object[] {A126PRG_COD});
            while ( (pr_default.getStatus(7) != 101) )
            {
               A361MNU_NIV = P00019_A361MNU_NIV[0] ;
               A117PRG_WEB = P00019_A117PRG_WEB[0] ;
               A129MNU_NID = P00019_A129MNU_NID[0] ;
               A117PRG_WEB = P00019_A117PRG_WEB[0] ;
               Gxm3smoothnavmenudata_items = new SdtSmoothNavMenuData_SmoothNavMenuItem(context) ;
               Gxm1smoothnavmenudata.gxTpr_Items.Add(Gxm3smoothnavmenudata_items, 0);
               Gxm3smoothnavmenudata_items.gxTpr_Id = StringUtil.Str( (decimal)(A126PRG_COD), 4, 0) ;
               Gxm3smoothnavmenudata_items.gxTpr_Title = A129MNU_NID ;
               Gxm3smoothnavmenudata_items.gxTpr_Description = A129MNU_NID ;
               Gxm3smoothnavmenudata_items.gxTpr_Link = "#" ;
               /* Using cursor P000110 */
               pr_default.execute(8, new Object[] {A126PRG_COD, A361MNU_NIV});
               while ( (pr_default.getStatus(8) != 101) )
               {
                  A131MNU_DSN = P000110_A131MNU_DSN[0] ;
                  A132MNU_SLINK = P000110_A132MNU_SLINK[0] ;
                  A130MNU_SNI = P000110_A130MNU_SNI[0] ;
                  Gxm4smoothnavmenudata_items_items = new SdtSmoothNavMenuData_SmoothNavMenuItem(context) ;
                  Gxm3smoothnavmenudata_items.gxTpr_Items.Add(Gxm4smoothnavmenudata_items_items, 0);
                  Gxm4smoothnavmenudata_items_items.gxTpr_Id = StringUtil.Str( (decimal)(A126PRG_COD), 4, 0) ;
                  Gxm4smoothnavmenudata_items_items.gxTpr_Title = A131MNU_DSN ;
                  Gxm4smoothnavmenudata_items_items.gxTpr_Description = A131MNU_DSN ;
                  Gxm4smoothnavmenudata_items_items.gxTpr_Link = "HTTP://intranetamsX15/"+StringUtil.Trim( A132MNU_SLINK)+"?"+StringUtil.Trim( StringUtil.Str( (decimal)(AV6SIS_COD), 10, 0))+","+StringUtil.Trim( AV7USU_COD)+","+StringUtil.Trim( StringUtil.Str( (decimal)(AV5PRS_NRO), 10, 0)) ;
                  AV8NOM_COOKIE = "KEY_" + StringUtil.Trim( A117PRG_WEB) + "_" + StringUtil.Trim( AV7USU_COD) ;
                  AV9A = context.SetCookie( AV8NOM_COOKIE, StringUtil.Str( (decimal)(AV5PRS_NRO), 10, 0), "", (DateTime)(DateTime.MinValue), "", 0) ;
                  AV8NOM_COOKIE = "KEY_" + StringUtil.Trim( StringUtil.Str( (decimal)(A126PRG_COD), 10, 0)) + "_" + StringUtil.Trim( AV7USU_COD) ;
                  AV9A = context.SetCookie( AV8NOM_COOKIE, StringUtil.Str( (decimal)(AV5PRS_NRO), 10, 0), "", (DateTime)(DateTime.MinValue), "", 0) ;
                  pr_default.readNext(8);
               }
               pr_default.close(8);
               pr_default.readNext(7);
            }
            pr_default.close(7);
            pr_default.readNext(6);
         }
         pr_default.close(6);
         /* Using cursor P000111 */
         pr_default.execute(9, new Object[] {AV7USU_COD, AV6SIS_COD});
         while ( (pr_default.getStatus(9) != 101) )
         {
            A116SIS_COD = P000111_A116SIS_COD[0] ;
            A6USU_COD = P000111_A6USU_COD[0] ;
            A117PRG_WEB = P000111_A117PRG_WEB[0] ;
            A128PRG_EXT = P000111_A128PRG_EXT[0] ;
            A126PRG_COD = P000111_A126PRG_COD[0] ;
            A127PRG_DES = P000111_A127PRG_DES[0] ;
            A117PRG_WEB = P000111_A117PRG_WEB[0] ;
            A128PRG_EXT = P000111_A128PRG_EXT[0] ;
            A127PRG_DES = P000111_A127PRG_DES[0] ;
            Gxm1smoothnavmenudata = new SdtSmoothNavMenuData_SmoothNavMenuItem(context) ;
            Gxm2rootcol.Add(Gxm1smoothnavmenudata, 0);
            Gxm1smoothnavmenudata.gxTpr_Id = StringUtil.Str( (decimal)(A126PRG_COD), 4, 0) ;
            Gxm1smoothnavmenudata.gxTpr_Title = A127PRG_DES ;
            Gxm1smoothnavmenudata.gxTpr_Description = A127PRG_DES ;
            Gxm1smoothnavmenudata.gxTpr_Link = "HTTP://intranetams/"+StringUtil.Trim( A117PRG_WEB)+"?"+StringUtil.Trim( StringUtil.Str( (decimal)(AV6SIS_COD), 10, 0))+","+StringUtil.Trim( AV7USU_COD)+","+StringUtil.Trim( StringUtil.Str( (decimal)(AV5PRS_NRO), 10, 0)) ;
            AV8NOM_COOKIE = "KEY_" + StringUtil.Trim( A117PRG_WEB) + "_" + StringUtil.Trim( AV7USU_COD) ;
            AV9A = context.SetCookie( AV8NOM_COOKIE, StringUtil.Str( (decimal)(AV5PRS_NRO), 10, 0), "", (DateTime)(DateTime.MinValue), "", 0) ;
            AV8NOM_COOKIE = "KEY_" + StringUtil.Trim( StringUtil.Str( (decimal)(A126PRG_COD), 10, 0)) + "_" + StringUtil.Trim( AV7USU_COD) ;
            AV9A = context.SetCookie( AV8NOM_COOKIE, StringUtil.Str( (decimal)(AV5PRS_NRO), 10, 0), "", (DateTime)(DateTime.MinValue), "", 0) ;
            Gxm1smoothnavmenudata.gxTpr_Linktarget = "_blank" ;
            pr_default.readNext(9);
         }
         pr_default.close(9);
         /* Using cursor P000112 */
         pr_default.execute(10, new Object[] {AV7USU_COD, AV6SIS_COD});
         while ( (pr_default.getStatus(10) != 101) )
         {
            A116SIS_COD = P000112_A116SIS_COD[0] ;
            A6USU_COD = P000112_A6USU_COD[0] ;
            A117PRG_WEB = P000112_A117PRG_WEB[0] ;
            A128PRG_EXT = P000112_A128PRG_EXT[0] ;
            A126PRG_COD = P000112_A126PRG_COD[0] ;
            A127PRG_DES = P000112_A127PRG_DES[0] ;
            A117PRG_WEB = P000112_A117PRG_WEB[0] ;
            A128PRG_EXT = P000112_A128PRG_EXT[0] ;
            A127PRG_DES = P000112_A127PRG_DES[0] ;
            Gxm1smoothnavmenudata = new SdtSmoothNavMenuData_SmoothNavMenuItem(context) ;
            Gxm2rootcol.Add(Gxm1smoothnavmenudata, 0);
            Gxm1smoothnavmenudata.gxTpr_Id = StringUtil.Str( (decimal)(A126PRG_COD), 4, 0) ;
            Gxm1smoothnavmenudata.gxTpr_Title = A127PRG_DES ;
            Gxm1smoothnavmenudata.gxTpr_Description = A127PRG_DES ;
            Gxm1smoothnavmenudata.gxTpr_Link = "HTTP://www.esancorsalud.com.ar/hlogine.aspx" ;
            AV8NOM_COOKIE = "KEY_" + StringUtil.Trim( A117PRG_WEB) + "_" + StringUtil.Trim( AV7USU_COD) ;
            AV9A = context.SetCookie( AV8NOM_COOKIE, StringUtil.Str( (decimal)(AV5PRS_NRO), 10, 0), "", (DateTime)(DateTime.MinValue), "", 0) ;
            AV8NOM_COOKIE = "KEY_" + StringUtil.Trim( StringUtil.Str( (decimal)(A126PRG_COD), 10, 0)) + "_" + StringUtil.Trim( AV7USU_COD) ;
            AV9A = context.SetCookie( AV8NOM_COOKIE, StringUtil.Str( (decimal)(AV5PRS_NRO), 10, 0), "", (DateTime)(DateTime.MinValue), "", 0) ;
            Gxm1smoothnavmenudata.gxTpr_Linktarget = "_blank" ;
            pr_default.readNext(10);
         }
         pr_default.close(10);
         this.cleanup();
      }

      protected void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         scmdbuf = "" ;
         P00012_A126PRG_COD = new short[1] ;
         P00012_A116SIS_COD = new short[1] ;
         P00012_A6USU_COD = new String[] {""} ;
         P00012_A117PRG_WEB = new String[] {""} ;
         P00012_A128PRG_EXT = new String[] {""} ;
         P00012_A127PRG_DES = new String[] {""} ;
         A6USU_COD = "" ;
         A117PRG_WEB = "" ;
         A128PRG_EXT = "" ;
         A127PRG_DES = "" ;
         Gxm1smoothnavmenudata = new SdtSmoothNavMenuData_SmoothNavMenuItem(context);
         P00013_A126PRG_COD = new short[1] ;
         P00013_A361MNU_NIV = new int[1] ;
         P00013_A117PRG_WEB = new String[] {""} ;
         P00013_A129MNU_NID = new String[] {""} ;
         A129MNU_NID = "" ;
         Gxm3smoothnavmenudata_items = new SdtSmoothNavMenuData_SmoothNavMenuItem(context);
         P00014_A126PRG_COD = new short[1] ;
         P00014_A361MNU_NIV = new int[1] ;
         P00014_A131MNU_DSN = new String[] {""} ;
         P00014_A132MNU_SLINK = new String[] {""} ;
         P00014_A130MNU_SNI = new int[1] ;
         A131MNU_DSN = "" ;
         A132MNU_SLINK = "" ;
         Gxm4smoothnavmenudata_items_items = new SdtSmoothNavMenuData_SmoothNavMenuItem(context);
         AV8NOM_COOKIE = "" ;
         P00015_A126PRG_COD = new short[1] ;
         P00015_A116SIS_COD = new short[1] ;
         P00015_A6USU_COD = new String[] {""} ;
         P00015_A117PRG_WEB = new String[] {""} ;
         P00015_A128PRG_EXT = new String[] {""} ;
         P00015_A127PRG_DES = new String[] {""} ;
         P00016_A126PRG_COD = new short[1] ;
         P00016_A361MNU_NIV = new int[1] ;
         P00016_A117PRG_WEB = new String[] {""} ;
         P00016_A129MNU_NID = new String[] {""} ;
         P00017_A126PRG_COD = new short[1] ;
         P00017_A361MNU_NIV = new int[1] ;
         P00017_A131MNU_DSN = new String[] {""} ;
         P00017_A132MNU_SLINK = new String[] {""} ;
         P00017_A130MNU_SNI = new int[1] ;
         P00018_A126PRG_COD = new short[1] ;
         P00018_A116SIS_COD = new short[1] ;
         P00018_A6USU_COD = new String[] {""} ;
         P00018_A117PRG_WEB = new String[] {""} ;
         P00018_A128PRG_EXT = new String[] {""} ;
         P00018_A127PRG_DES = new String[] {""} ;
         P00019_A126PRG_COD = new short[1] ;
         P00019_A361MNU_NIV = new int[1] ;
         P00019_A117PRG_WEB = new String[] {""} ;
         P00019_A129MNU_NID = new String[] {""} ;
         P000110_A126PRG_COD = new short[1] ;
         P000110_A361MNU_NIV = new int[1] ;
         P000110_A131MNU_DSN = new String[] {""} ;
         P000110_A132MNU_SLINK = new String[] {""} ;
         P000110_A130MNU_SNI = new int[1] ;
         P000111_A116SIS_COD = new short[1] ;
         P000111_A6USU_COD = new String[] {""} ;
         P000111_A117PRG_WEB = new String[] {""} ;
         P000111_A128PRG_EXT = new String[] {""} ;
         P000111_A126PRG_COD = new short[1] ;
         P000111_A127PRG_DES = new String[] {""} ;
         GXt_char1 = "" ;
         P000112_A116SIS_COD = new short[1] ;
         P000112_A6USU_COD = new String[] {""} ;
         P000112_A117PRG_WEB = new String[] {""} ;
         P000112_A128PRG_EXT = new String[] {""} ;
         P000112_A126PRG_COD = new short[1] ;
         P000112_A127PRG_DES = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.smoothnavmenudatamp__default(),
            new Object[][] {
                new Object[] {
               P00012_A126PRG_COD, P00012_A116SIS_COD, P00012_A6USU_COD, P00012_A117PRG_WEB, P00012_A128PRG_EXT, P00012_A127PRG_DES
               }
               , new Object[] {
               P00013_A126PRG_COD, P00013_A361MNU_NIV, P00013_A117PRG_WEB, P00013_A129MNU_NID
               }
               , new Object[] {
               P00014_A126PRG_COD, P00014_A361MNU_NIV, P00014_A131MNU_DSN, P00014_A132MNU_SLINK, P00014_A130MNU_SNI
               }
               , new Object[] {
               P00015_A126PRG_COD, P00015_A116SIS_COD, P00015_A6USU_COD, P00015_A117PRG_WEB, P00015_A128PRG_EXT, P00015_A127PRG_DES
               }
               , new Object[] {
               P00016_A126PRG_COD, P00016_A361MNU_NIV, P00016_A117PRG_WEB, P00016_A129MNU_NID
               }
               , new Object[] {
               P00017_A126PRG_COD, P00017_A361MNU_NIV, P00017_A131MNU_DSN, P00017_A132MNU_SLINK, P00017_A130MNU_SNI
               }
               , new Object[] {
               P00018_A126PRG_COD, P00018_A116SIS_COD, P00018_A6USU_COD, P00018_A117PRG_WEB, P00018_A128PRG_EXT, P00018_A127PRG_DES
               }
               , new Object[] {
               P00019_A126PRG_COD, P00019_A361MNU_NIV, P00019_A117PRG_WEB, P00019_A129MNU_NID
               }
               , new Object[] {
               P000110_A126PRG_COD, P000110_A361MNU_NIV, P000110_A131MNU_DSN, P000110_A132MNU_SLINK, P000110_A130MNU_SNI
               }
               , new Object[] {
               P000111_A116SIS_COD, P000111_A6USU_COD, P000111_A117PRG_WEB, P000111_A128PRG_EXT, P000111_A126PRG_COD, P000111_A127PRG_DES
               }
               , new Object[] {
               P000112_A116SIS_COD, P000112_A6USU_COD, P000112_A117PRG_WEB, P000112_A128PRG_EXT, P000112_A126PRG_COD, P000112_A127PRG_DES
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV6SIS_COD ;
      private short A126PRG_COD ;
      private short A116SIS_COD ;
      private short AV9A ;
      private int AV5PRS_NRO ;
      private int A361MNU_NIV ;
      private int A130MNU_SNI ;
      private String AV7USU_COD ;
      private String AV11SERVER ;
      private String scmdbuf ;
      private String A6USU_COD ;
      private String A117PRG_WEB ;
      private String A128PRG_EXT ;
      private String A127PRG_DES ;
      private String A129MNU_NID ;
      private String A131MNU_DSN ;
      private String AV8NOM_COOKIE ;
      private String GXt_char1 ;
      private String A132MNU_SLINK ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00012_A126PRG_COD ;
      private short[] P00012_A116SIS_COD ;
      private String[] P00012_A6USU_COD ;
      private String[] P00012_A117PRG_WEB ;
      private String[] P00012_A128PRG_EXT ;
      private String[] P00012_A127PRG_DES ;
      private short[] P00013_A126PRG_COD ;
      private int[] P00013_A361MNU_NIV ;
      private String[] P00013_A117PRG_WEB ;
      private String[] P00013_A129MNU_NID ;
      private short[] P00014_A126PRG_COD ;
      private int[] P00014_A361MNU_NIV ;
      private String[] P00014_A131MNU_DSN ;
      private String[] P00014_A132MNU_SLINK ;
      private int[] P00014_A130MNU_SNI ;
      private short[] P00015_A126PRG_COD ;
      private short[] P00015_A116SIS_COD ;
      private String[] P00015_A6USU_COD ;
      private String[] P00015_A117PRG_WEB ;
      private String[] P00015_A128PRG_EXT ;
      private String[] P00015_A127PRG_DES ;
      private short[] P00016_A126PRG_COD ;
      private int[] P00016_A361MNU_NIV ;
      private String[] P00016_A117PRG_WEB ;
      private String[] P00016_A129MNU_NID ;
      private short[] P00017_A126PRG_COD ;
      private int[] P00017_A361MNU_NIV ;
      private String[] P00017_A131MNU_DSN ;
      private String[] P00017_A132MNU_SLINK ;
      private int[] P00017_A130MNU_SNI ;
      private short[] P00018_A126PRG_COD ;
      private short[] P00018_A116SIS_COD ;
      private String[] P00018_A6USU_COD ;
      private String[] P00018_A117PRG_WEB ;
      private String[] P00018_A128PRG_EXT ;
      private String[] P00018_A127PRG_DES ;
      private short[] P00019_A126PRG_COD ;
      private int[] P00019_A361MNU_NIV ;
      private String[] P00019_A117PRG_WEB ;
      private String[] P00019_A129MNU_NID ;
      private short[] P000110_A126PRG_COD ;
      private int[] P000110_A361MNU_NIV ;
      private String[] P000110_A131MNU_DSN ;
      private String[] P000110_A132MNU_SLINK ;
      private int[] P000110_A130MNU_SNI ;
      private short[] P000111_A116SIS_COD ;
      private String[] P000111_A6USU_COD ;
      private String[] P000111_A117PRG_WEB ;
      private String[] P000111_A128PRG_EXT ;
      private short[] P000111_A126PRG_COD ;
      private String[] P000111_A127PRG_DES ;
      private short[] P000112_A116SIS_COD ;
      private String[] P000112_A6USU_COD ;
      private String[] P000112_A117PRG_WEB ;
      private String[] P000112_A128PRG_EXT ;
      private short[] P000112_A126PRG_COD ;
      private String[] P000112_A127PRG_DES ;
      private IGxCollection aP4_Gxm2rootcol ;
      [ObjectCollection(ItemType=typeof( SdtSmoothNavMenuData_SmoothNavMenuItem ))]
      private IGxCollection Gxm2rootcol ;
      private SdtSmoothNavMenuData_SmoothNavMenuItem Gxm1smoothnavmenudata ;
      private SdtSmoothNavMenuData_SmoothNavMenuItem Gxm3smoothnavmenudata_items ;
      private SdtSmoothNavMenuData_SmoothNavMenuItem Gxm4smoothnavmenudata_items_items ;
   }

   public class smoothnavmenudatamp__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00012 ;
          prmP00012 = new Object[] {
          new Object[] {"@AV7USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@AV6SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP00013 ;
          prmP00013 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP00014 ;
          prmP00014 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0}
          } ;
          Object[] prmP00015 ;
          prmP00015 = new Object[] {
          new Object[] {"@AV7USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@AV6SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP00016 ;
          prmP00016 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP00017 ;
          prmP00017 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0}
          } ;
          Object[] prmP00018 ;
          prmP00018 = new Object[] {
          new Object[] {"@AV7USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@AV6SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP00019 ;
          prmP00019 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP000110 ;
          prmP000110 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0}
          } ;
          Object[] prmP000111 ;
          prmP000111 = new Object[] {
          new Object[] {"@AV7USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@AV6SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP000112 ;
          prmP000112 = new Object[] {
          new Object[] {"@AV7USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@AV6SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00012", "SELECT T1.[PRG_COD], T1.[SIS_COD], T1.[USU_COD], T2.[PRG_WEB], T2.[PRG_EXT], T2.[PRG_DES] FROM ([SEG004] T1 WITH (NOLOCK) INNER JOIN [SEG001] T2 WITH (NOLOCK) ON T2.[PRG_COD] = T1.[PRG_COD]) WHERE (T1.[USU_COD] = @AV7USU_COD and T1.[SIS_COD] = @AV6SIS_COD) AND (T2.[PRG_WEB] <> ' ') AND (T2.[PRG_EXT] = 'X') ORDER BY T1.[USU_COD], T1.[SIS_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00012,100,1,true,false )
             ,new CursorDef("P00013", "SELECT T1.[PRG_COD], T1.[MNU_NIV], T2.[PRG_WEB], T1.[MNU_NID] FROM ([SEG008] T1 WITH (NOLOCK) INNER JOIN [SEG001] T2 WITH (NOLOCK) ON T2.[PRG_COD] = T1.[PRG_COD]) WHERE T1.[PRG_COD] = @PRG_COD ORDER BY T1.[PRG_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00013,100,1,true,false )
             ,new CursorDef("P00014", "SELECT [PRG_COD], [MNU_NIV], [MNU_DSN], [MNU_SLINK], [MNU_SNI] FROM [SEG008L1] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD and [MNU_NIV] = @MNU_NIV ORDER BY [PRG_COD], [MNU_NIV], [MNU_SNI] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00014,100,1,false,false )
             ,new CursorDef("P00015", "SELECT T1.[PRG_COD], T1.[SIS_COD], T1.[USU_COD], T2.[PRG_WEB], T2.[PRG_EXT], T2.[PRG_DES] FROM ([SEG004] T1 WITH (NOLOCK) INNER JOIN [SEG001] T2 WITH (NOLOCK) ON T2.[PRG_COD] = T1.[PRG_COD]) WHERE (T1.[USU_COD] = @AV7USU_COD and T1.[SIS_COD] = @AV6SIS_COD) AND (T2.[PRG_WEB] <> ' ') AND (T2.[PRG_EXT] = '3') ORDER BY T1.[USU_COD], T1.[SIS_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00015,100,1,true,false )
             ,new CursorDef("P00016", "SELECT T1.[PRG_COD], T1.[MNU_NIV], T2.[PRG_WEB], T1.[MNU_NID] FROM ([SEG008] T1 WITH (NOLOCK) INNER JOIN [SEG001] T2 WITH (NOLOCK) ON T2.[PRG_COD] = T1.[PRG_COD]) WHERE T1.[PRG_COD] = @PRG_COD ORDER BY T1.[PRG_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00016,100,1,true,false )
             ,new CursorDef("P00017", "SELECT [PRG_COD], [MNU_NIV], [MNU_DSN], [MNU_SLINK], [MNU_SNI] FROM [SEG008L1] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD and [MNU_NIV] = @MNU_NIV ORDER BY [PRG_COD], [MNU_NIV], [MNU_SNI] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00017,100,1,false,false )
             ,new CursorDef("P00018", "SELECT T1.[PRG_COD], T1.[SIS_COD], T1.[USU_COD], T2.[PRG_WEB], T2.[PRG_EXT], T2.[PRG_DES] FROM ([SEG004] T1 WITH (NOLOCK) INNER JOIN [SEG001] T2 WITH (NOLOCK) ON T2.[PRG_COD] = T1.[PRG_COD]) WHERE (T1.[USU_COD] = @AV7USU_COD and T1.[SIS_COD] = @AV6SIS_COD) AND (T2.[PRG_WEB] <> ' ') AND (T2.[PRG_EXT] = '5') ORDER BY T1.[USU_COD], T1.[SIS_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00018,100,1,true,false )
             ,new CursorDef("P00019", "SELECT T1.[PRG_COD], T1.[MNU_NIV], T2.[PRG_WEB], T1.[MNU_NID] FROM ([SEG008] T1 WITH (NOLOCK) INNER JOIN [SEG001] T2 WITH (NOLOCK) ON T2.[PRG_COD] = T1.[PRG_COD]) WHERE T1.[PRG_COD] = @PRG_COD ORDER BY T1.[PRG_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00019,100,1,true,false )
             ,new CursorDef("P000110", "SELECT [PRG_COD], [MNU_NIV], [MNU_DSN], [MNU_SLINK], [MNU_SNI] FROM [SEG008L1] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD and [MNU_NIV] = @MNU_NIV ORDER BY [PRG_COD], [MNU_NIV], [MNU_SNI] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000110,100,1,false,false )
             ,new CursorDef("P000111", "SELECT T1.[SIS_COD], T1.[USU_COD], T2.[PRG_WEB], T2.[PRG_EXT], T1.[PRG_COD], T2.[PRG_DES] FROM ([SEG004] T1 WITH (NOLOCK) INNER JOIN [SEG001] T2 WITH (NOLOCK) ON T2.[PRG_COD] = T1.[PRG_COD]) WHERE (T1.[USU_COD] = @AV7USU_COD and T1.[SIS_COD] = @AV6SIS_COD) AND (T2.[PRG_EXT] <> 'B') AND (T2.[PRG_EXT] <> 'E') AND (T2.[PRG_EXT] <> '5') AND (T2.[PRG_EXT] <> '3') AND (T2.[PRG_EXT] <> 'X') AND (T2.[PRG_WEB] <> ' ') ORDER BY T1.[USU_COD], T1.[SIS_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000111,100,1,false,false )
             ,new CursorDef("P000112", "SELECT T1.[SIS_COD], T1.[USU_COD], T2.[PRG_WEB], T2.[PRG_EXT], T1.[PRG_COD], T2.[PRG_DES] FROM ([SEG004] T1 WITH (NOLOCK) INNER JOIN [SEG001] T2 WITH (NOLOCK) ON T2.[PRG_COD] = T1.[PRG_COD]) WHERE (T1.[USU_COD] = @AV7USU_COD and T1.[SIS_COD] = @AV6SIS_COD) AND (T2.[PRG_WEB] <> ' ') AND (T2.[PRG_EXT] = 'E') ORDER BY T1.[USU_COD], T1.[SIS_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000112,100,1,false,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 16) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 30) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 3) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 30) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 30) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 100) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 100) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                break;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 16) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 30) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 3) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 30) ;
                break;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 30) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 100) ;
                break;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 100) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                break;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 16) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 30) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 3) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 30) ;
                break;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 30) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 100) ;
                break;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 100) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                break;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 30) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 3) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 30) ;
                break;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 30) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 3) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 30) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
       }
    }

 }

}
