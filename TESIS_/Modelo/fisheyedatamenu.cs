/*
               File: FisheyeDataMenu
        Description: Fisheye Data Menu
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:17:33.68
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
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class fisheyedatamenu : GXProcedure
   {
      public fisheyedatamenu( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public fisheyedatamenu( IGxContext context )
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
                           out IGxCollection aP1_Gxm2rootcol )
      {
         this.AV7USU_COD = aP0_USU_COD;
         this.Gxm2rootcol = new GxObjectCollection( context, "FisheyeData.FisheyeDataItem", "MarianoTesis", "SdtFisheyeData_FisheyeDataItem", "GeneXus.Programs") ;
         initialize();
         executePrivate();
         aP1_Gxm2rootcol=this.Gxm2rootcol;
      }

      public IGxCollection executeUdp( String aP0_USU_COD )
      {
         this.AV7USU_COD = aP0_USU_COD;
         this.Gxm2rootcol = new GxObjectCollection( context, "FisheyeData.FisheyeDataItem", "MarianoTesis", "SdtFisheyeData_FisheyeDataItem", "GeneXus.Programs") ;
         initialize();
         executePrivate();
         aP1_Gxm2rootcol=this.Gxm2rootcol;
         return Gxm2rootcol ;
      }

      public void executeSubmit( String aP0_USU_COD ,
                                 out IGxCollection aP1_Gxm2rootcol )
      {
         fisheyedatamenu objfisheyedatamenu;
         objfisheyedatamenu = new fisheyedatamenu();
         objfisheyedatamenu.AV7USU_COD = aP0_USU_COD;
         objfisheyedatamenu.Gxm2rootcol = new GxObjectCollection( context, "FisheyeData.FisheyeDataItem", "MarianoTesis", "SdtFisheyeData_FisheyeDataItem", "GeneXus.Programs") ;
         objfisheyedatamenu.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objfisheyedatamenu.executePrivateCatch ));
         aP1_Gxm2rootcol=this.Gxm2rootcol;
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
         AV5basePath = "./" ;
         /* Using cursor P00022 */
         pr_default.execute(0, new Object[] {AV7USU_COD});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A6USU_COD = P00022_A6USU_COD[0] ;
            A125SIS_MEX = P00022_A125SIS_MEX[0] ;
            A116SIS_COD = P00022_A116SIS_COD[0] ;
            A123SIS_ICO = P00022_A123SIS_ICO[0] ;
            A125SIS_MEX = P00022_A125SIS_MEX[0] ;
            A123SIS_ICO = P00022_A123SIS_ICO[0] ;
            Gxm1fisheyedata = new SdtFisheyeData_FisheyeDataItem(context) ;
            Gxm2rootcol.Add(Gxm1fisheyedata, 0);
            Gxm1fisheyedata.gxTpr_Description = StringUtil.Trim( StringUtil.Str( (decimal)(A116SIS_COD), 10, 0)) ;
            AV6path = AV5basePath + "Fisheye/images/" + StringUtil.Trim( A123SIS_ICO) ;
            Gxm1fisheyedata.gxTpr_Image = AV6path ;
            Gxm1fisheyedata.gxTpr_Link = "http://www.genexus.com" ;
            Gxm1fisheyedata.gxTpr_Id = StringUtil.Trim( StringUtil.Str( (decimal)(A116SIS_COD), 10, 0)) ;
            pr_default.readNext(0);
         }
         pr_default.close(0);
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
         AV5basePath = "" ;
         scmdbuf = "" ;
         P00022_A6USU_COD = new String[] {""} ;
         P00022_A125SIS_MEX = new String[] {""} ;
         P00022_A116SIS_COD = new short[1] ;
         P00022_A123SIS_ICO = new String[] {""} ;
         A6USU_COD = "" ;
         A125SIS_MEX = "" ;
         A123SIS_ICO = "" ;
         Gxm1fisheyedata = new SdtFisheyeData_FisheyeDataItem(context);
         AV6path = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.fisheyedatamenu__default(),
            new Object[][] {
                new Object[] {
               P00022_A6USU_COD, P00022_A125SIS_MEX, P00022_A116SIS_COD, P00022_A123SIS_ICO
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A116SIS_COD ;
      private String AV7USU_COD ;
      private String AV5basePath ;
      private String scmdbuf ;
      private String A6USU_COD ;
      private String A125SIS_MEX ;
      private String A123SIS_ICO ;
      private String AV6path ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00022_A6USU_COD ;
      private String[] P00022_A125SIS_MEX ;
      private short[] P00022_A116SIS_COD ;
      private String[] P00022_A123SIS_ICO ;
      private IGxCollection aP1_Gxm2rootcol ;
      [ObjectCollection(ItemType=typeof( SdtFisheyeData_FisheyeDataItem ))]
      private IGxCollection Gxm2rootcol ;
      private SdtFisheyeData_FisheyeDataItem Gxm1fisheyedata ;
   }

   public class fisheyedatamenu__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00022 ;
          prmP00022 = new Object[] {
          new Object[] {"@AV7USU_COD",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00022", "SELECT T1.[USU_COD], T2.[SIS_MEX], T1.[SIS_COD], T2.[SIS_ICO] FROM ([SEG003] T1 WITH (NOLOCK) INNER JOIN [SEG000] T2 WITH (NOLOCK) ON T2.[SIS_COD] = T1.[SIS_COD]) WHERE (T1.[USU_COD] = @AV7USU_COD) AND (T2.[SIS_MEX] = 'X') ORDER BY T1.[USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00022,100,1,false,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 100) ;
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
                break;
       }
    }

 }

}
