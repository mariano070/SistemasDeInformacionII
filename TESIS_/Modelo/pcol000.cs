/*
               File: PCOL000
        Description: AGREGA PROCESO A LA COLA DE TRABAJOS
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:17:27.60
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
   public class pcol000 : GXProcedure
   {
      public pcol000( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pcol000( IGxContext context )
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

      public void execute( ref long aP0_PRC_NRO ,
                           ref DateTime aP1_PRC_ING ,
                           ref String aP2_PRC_NOM ,
                           ref String aP3_PRC_DES ,
                           ref String aP4_PRC_PAR ,
                           ref String aP5_PRC_USR ,
                           ref DateTime aP6_INICIO )
      {
         this.AV13PRC_NRO = aP0_PRC_NRO;
         this.AV11PRC_ING = aP1_PRC_ING;
         this.AV12PRC_NOM = aP2_PRC_NOM;
         this.AV10PRC_DES = aP3_PRC_DES;
         this.AV14PRC_PAR = aP4_PRC_PAR;
         this.AV15PRC_USR = aP5_PRC_USR;
         this.AV9INICIO = aP6_INICIO;
         initialize();
         executePrivate();
         aP0_PRC_NRO=this.AV13PRC_NRO;
         aP1_PRC_ING=this.AV11PRC_ING;
         aP2_PRC_NOM=this.AV12PRC_NOM;
         aP3_PRC_DES=this.AV10PRC_DES;
         aP4_PRC_PAR=this.AV14PRC_PAR;
         aP5_PRC_USR=this.AV15PRC_USR;
         aP6_INICIO=this.AV9INICIO;
      }

      public DateTime executeUdp( ref long aP0_PRC_NRO ,
                                  ref DateTime aP1_PRC_ING ,
                                  ref String aP2_PRC_NOM ,
                                  ref String aP3_PRC_DES ,
                                  ref String aP4_PRC_PAR ,
                                  ref String aP5_PRC_USR )
      {
         this.AV13PRC_NRO = aP0_PRC_NRO;
         this.AV11PRC_ING = aP1_PRC_ING;
         this.AV12PRC_NOM = aP2_PRC_NOM;
         this.AV10PRC_DES = aP3_PRC_DES;
         this.AV14PRC_PAR = aP4_PRC_PAR;
         this.AV15PRC_USR = aP5_PRC_USR;
         this.AV9INICIO = aP6_INICIO;
         initialize();
         executePrivate();
         aP0_PRC_NRO=this.AV13PRC_NRO;
         aP1_PRC_ING=this.AV11PRC_ING;
         aP2_PRC_NOM=this.AV12PRC_NOM;
         aP3_PRC_DES=this.AV10PRC_DES;
         aP4_PRC_PAR=this.AV14PRC_PAR;
         aP5_PRC_USR=this.AV15PRC_USR;
         aP6_INICIO=this.AV9INICIO;
         return AV9INICIO ;
      }

      public void executeSubmit( ref long aP0_PRC_NRO ,
                                 ref DateTime aP1_PRC_ING ,
                                 ref String aP2_PRC_NOM ,
                                 ref String aP3_PRC_DES ,
                                 ref String aP4_PRC_PAR ,
                                 ref String aP5_PRC_USR ,
                                 ref DateTime aP6_INICIO )
      {
         pcol000 objpcol000;
         objpcol000 = new pcol000();
         objpcol000.AV13PRC_NRO = aP0_PRC_NRO;
         objpcol000.AV11PRC_ING = aP1_PRC_ING;
         objpcol000.AV12PRC_NOM = aP2_PRC_NOM;
         objpcol000.AV10PRC_DES = aP3_PRC_DES;
         objpcol000.AV14PRC_PAR = aP4_PRC_PAR;
         objpcol000.AV15PRC_USR = aP5_PRC_USR;
         objpcol000.AV9INICIO = aP6_INICIO;
         objpcol000.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpcol000.executePrivateCatch ));
         aP0_PRC_NRO=this.AV13PRC_NRO;
         aP1_PRC_ING=this.AV11PRC_ING;
         aP2_PRC_NOM=this.AV12PRC_NOM;
         aP3_PRC_DES=this.AV10PRC_DES;
         aP4_PRC_PAR=this.AV14PRC_PAR;
         aP5_PRC_USR=this.AV15PRC_USR;
         aP6_INICIO=this.AV9INICIO;
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
         AV8AHORA = DateTimeUtil.Now( ) ;
         AV16PRC_VER = " " ;
         AV17VprNombreX = AV12PRC_NOM ;
         /* Using cursor P000F2 */
         pr_default.execute(0, new Object[] {AV12PRC_NOM});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A99VprPrc = P000F2_A99VprPrc[0] ;
            A101VprVer = P000F2_A101VprVer[0] ;
            A100VprNombreX = P000F2_A100VprNombreX[0] ;
            AV16PRC_VER = A101VprVer ;
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A100VprNombreX)) )
            {
               AV17VprNombreX = A100VprNombreX ;
            }
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         /*
            INSERT RECORD ON TABLE COL000

         */
         A79PRC_NRO = AV13PRC_NRO ;
         A92PRC_ING = AV11PRC_ING ;
         A93PRC_NOM = AV17VprNombreX ;
         A95PRC_DES = AV10PRC_DES ;
         A80PRC_PAR = AV14PRC_PAR ;
         A94PRC_USR = AV15PRC_USR ;
         A96PRC_INI = AV9INICIO ;
         A97PRC_EML = AV8AHORA ;
         A98PRC_VER = AV16PRC_VER ;
         /* Using cursor P000F3 */
         pr_default.execute(1, new Object[] {A79PRC_NRO, A92PRC_ING, A96PRC_INI, A93PRC_NOM, A95PRC_DES, A80PRC_PAR, A94PRC_USR, A97PRC_EML, A98PRC_VER});
         pr_default.close(1);
         if ( (pr_default.getStatus(1) == 1) )
         {
            context.Gx_err = 1 ;
            Gx_emsg = (String)(context.GetMessage( "GXM_noupdate")) ;
         }
         else
         {
            context.Gx_err = 0 ;
            Gx_emsg = "" ;
         }
         /* End Insert */
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PCOL000");
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
         AV8AHORA = (DateTime)(DateTime.MinValue) ;
         AV16PRC_VER = "" ;
         AV17VprNombreX = "" ;
         scmdbuf = "" ;
         P000F2_A99VprPrc = new String[] {""} ;
         P000F2_A101VprVer = new String[] {""} ;
         P000F2_A100VprNombreX = new String[] {""} ;
         A99VprPrc = "" ;
         A101VprVer = "" ;
         A100VprNombreX = "" ;
         A92PRC_ING = (DateTime)(DateTime.MinValue) ;
         A93PRC_NOM = "" ;
         A95PRC_DES = "" ;
         A80PRC_PAR = "" ;
         A94PRC_USR = "" ;
         A96PRC_INI = (DateTime)(DateTime.MinValue) ;
         A97PRC_EML = (DateTime)(DateTime.MinValue) ;
         A98PRC_VER = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pcol000__default(),
            new Object[][] {
                new Object[] {
               P000F2_A99VprPrc, P000F2_A101VprVer, P000F2_A100VprNombreX
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int GX_INS4 ;
      private long AV13PRC_NRO ;
      private long A79PRC_NRO ;
      private String AV12PRC_NOM ;
      private String AV10PRC_DES ;
      private String AV14PRC_PAR ;
      private String AV15PRC_USR ;
      private String AV16PRC_VER ;
      private String AV17VprNombreX ;
      private String scmdbuf ;
      private String A99VprPrc ;
      private String A101VprVer ;
      private String A100VprNombreX ;
      private String A93PRC_NOM ;
      private String A95PRC_DES ;
      private String A80PRC_PAR ;
      private String A94PRC_USR ;
      private String A98PRC_VER ;
      private String Gx_emsg ;
      private DateTime AV11PRC_ING ;
      private DateTime AV9INICIO ;
      private DateTime AV8AHORA ;
      private DateTime A92PRC_ING ;
      private DateTime A96PRC_INI ;
      private DateTime A97PRC_EML ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private long aP0_PRC_NRO ;
      private DateTime aP1_PRC_ING ;
      private String aP2_PRC_NOM ;
      private String aP3_PRC_DES ;
      private String aP4_PRC_PAR ;
      private String aP5_PRC_USR ;
      private DateTime aP6_INICIO ;
      private IDataStoreProvider pr_default ;
      private String[] P000F2_A99VprPrc ;
      private String[] P000F2_A101VprVer ;
      private String[] P000F2_A100VprNombreX ;
   }

   public class pcol000__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000F2 ;
          prmP000F2 = new Object[] {
          new Object[] {"@AV12PRC_NOM",SqlDbType.Char,30,0}
          } ;
          Object[] prmP000F3 ;
          prmP000F3 = new Object[] {
          new Object[] {"@PRC_NRO",SqlDbType.Decimal,10,0} ,
          new Object[] {"@PRC_ING",SqlDbType.DateTime,8,5} ,
          new Object[] {"@PRC_INI",SqlDbType.DateTime,8,5} ,
          new Object[] {"@PRC_NOM",SqlDbType.Char,30,0} ,
          new Object[] {"@PRC_DES",SqlDbType.Char,50,0} ,
          new Object[] {"@PRC_PAR",SqlDbType.Char,100,0} ,
          new Object[] {"@PRC_USR",SqlDbType.Char,16,0} ,
          new Object[] {"@PRC_EML",SqlDbType.DateTime,8,5} ,
          new Object[] {"@PRC_VER",SqlDbType.Char,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000F2", "SELECT [VprPrc], [VprVer], [VprNombreX] FROM [PRC002] WITH (NOLOCK) WHERE [VprPrc] = @AV12PRC_NOM ORDER BY [VprPrc] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F2,1,0,false,true )
             ,new CursorDef("P000F3", "INSERT INTO [COL000] ([PRC_NRO], [PRC_ING], [PRC_INI], [PRC_NOM], [PRC_DES], [PRC_PAR], [PRC_USR], [PRC_EML], [PRC_VER], [PRC_FIN], [PRC_INV], [PRC_EST], [PRC_SAL], [PRC_PRS], [PRC_MSG], [PRC_SRV]) VALUES (@PRC_NRO, @PRC_ING, @PRC_INI, @PRC_NOM, @PRC_DES, @PRC_PAR, @PRC_USR, @PRC_EML, @PRC_VER, convert( DATETIME, '17530101', 112 ), '', convert(int, 0), '', '', '', '')", GxErrorMask.GX_NOMASK,prmP000F3)
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
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
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
             case 1 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (DateTime)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                break;
       }
    }

 }

}
