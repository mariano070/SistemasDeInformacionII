/*
               File: PTTBUS000_1
        Description: Guarda la ubicacion y área en la grilla de ubicaciones
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:4.83
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
   public class pttbus000_1 : GXProcedure
   {
      public pttbus000_1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pttbus000_1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref int aP0_TTBUS2_IdBien ,
                           ref short aP1_TTBUS2_CodPosDesde ,
                           ref String aP2_TTBUS2_RespDesde ,
                           ref DateTime aP3_TTBUS2_FechaEnvio ,
                           ref short aP4_TTBUS2_CodPosHacia ,
                           ref String aP5_TTBUS2_RespHacia ,
                           ref DateTime aP6_TTBUS2_FechaRecepcion ,
                           ref short aP7_TTBUS2_EstadoEnvio ,
                           ref String aP8_TTBUS2_MotivoEnvio ,
                           ref String aP9_TTBUS2_Observaciones ,
                           ref String aP10_Modo ,
                           ref String aP11_USUARIO ,
                           ref DateTime aP12_TTBUS2_PlazoRecepcion )
      {
         this.AV19TTBUS2_IdBien = aP0_TTBUS2_IdBien;
         this.AV35TTBUS2_CodPosDesde = aP1_TTBUS2_CodPosDesde;
         this.AV22TTBUS2_RespDesde = aP2_TTBUS2_RespDesde;
         this.AV23TTBUS2_FechaEnvio = aP3_TTBUS2_FechaEnvio;
         this.AV34TTBUS2_CodPosHacia = aP4_TTBUS2_CodPosHacia;
         this.AV26TTBUS2_RespHacia = aP5_TTBUS2_RespHacia;
         this.AV27TTBUS2_FechaRecepcion = aP6_TTBUS2_FechaRecepcion;
         this.AV28TTBUS2_EstadoEnvio = aP7_TTBUS2_EstadoEnvio;
         this.AV17TTBUS2_MotivoEnvio = aP8_TTBUS2_MotivoEnvio;
         this.AV18TTBUS2_Observaciones = aP9_TTBUS2_Observaciones;
         this.AV16Modo = aP10_Modo;
         this.AV31USUARIO = aP11_USUARIO;
         this.AV37TTBUS2_PlazoRecepcion = aP12_TTBUS2_PlazoRecepcion;
         initialize();
         executePrivate();
         aP0_TTBUS2_IdBien=this.AV19TTBUS2_IdBien;
         aP1_TTBUS2_CodPosDesde=this.AV35TTBUS2_CodPosDesde;
         aP2_TTBUS2_RespDesde=this.AV22TTBUS2_RespDesde;
         aP3_TTBUS2_FechaEnvio=this.AV23TTBUS2_FechaEnvio;
         aP4_TTBUS2_CodPosHacia=this.AV34TTBUS2_CodPosHacia;
         aP5_TTBUS2_RespHacia=this.AV26TTBUS2_RespHacia;
         aP6_TTBUS2_FechaRecepcion=this.AV27TTBUS2_FechaRecepcion;
         aP7_TTBUS2_EstadoEnvio=this.AV28TTBUS2_EstadoEnvio;
         aP8_TTBUS2_MotivoEnvio=this.AV17TTBUS2_MotivoEnvio;
         aP9_TTBUS2_Observaciones=this.AV18TTBUS2_Observaciones;
         aP10_Modo=this.AV16Modo;
         aP11_USUARIO=this.AV31USUARIO;
         aP12_TTBUS2_PlazoRecepcion=this.AV37TTBUS2_PlazoRecepcion;
      }

      public DateTime executeUdp( ref int aP0_TTBUS2_IdBien ,
                                  ref short aP1_TTBUS2_CodPosDesde ,
                                  ref String aP2_TTBUS2_RespDesde ,
                                  ref DateTime aP3_TTBUS2_FechaEnvio ,
                                  ref short aP4_TTBUS2_CodPosHacia ,
                                  ref String aP5_TTBUS2_RespHacia ,
                                  ref DateTime aP6_TTBUS2_FechaRecepcion ,
                                  ref short aP7_TTBUS2_EstadoEnvio ,
                                  ref String aP8_TTBUS2_MotivoEnvio ,
                                  ref String aP9_TTBUS2_Observaciones ,
                                  ref String aP10_Modo ,
                                  ref String aP11_USUARIO )
      {
         this.AV19TTBUS2_IdBien = aP0_TTBUS2_IdBien;
         this.AV35TTBUS2_CodPosDesde = aP1_TTBUS2_CodPosDesde;
         this.AV22TTBUS2_RespDesde = aP2_TTBUS2_RespDesde;
         this.AV23TTBUS2_FechaEnvio = aP3_TTBUS2_FechaEnvio;
         this.AV34TTBUS2_CodPosHacia = aP4_TTBUS2_CodPosHacia;
         this.AV26TTBUS2_RespHacia = aP5_TTBUS2_RespHacia;
         this.AV27TTBUS2_FechaRecepcion = aP6_TTBUS2_FechaRecepcion;
         this.AV28TTBUS2_EstadoEnvio = aP7_TTBUS2_EstadoEnvio;
         this.AV17TTBUS2_MotivoEnvio = aP8_TTBUS2_MotivoEnvio;
         this.AV18TTBUS2_Observaciones = aP9_TTBUS2_Observaciones;
         this.AV16Modo = aP10_Modo;
         this.AV31USUARIO = aP11_USUARIO;
         this.AV37TTBUS2_PlazoRecepcion = aP12_TTBUS2_PlazoRecepcion;
         initialize();
         executePrivate();
         aP0_TTBUS2_IdBien=this.AV19TTBUS2_IdBien;
         aP1_TTBUS2_CodPosDesde=this.AV35TTBUS2_CodPosDesde;
         aP2_TTBUS2_RespDesde=this.AV22TTBUS2_RespDesde;
         aP3_TTBUS2_FechaEnvio=this.AV23TTBUS2_FechaEnvio;
         aP4_TTBUS2_CodPosHacia=this.AV34TTBUS2_CodPosHacia;
         aP5_TTBUS2_RespHacia=this.AV26TTBUS2_RespHacia;
         aP6_TTBUS2_FechaRecepcion=this.AV27TTBUS2_FechaRecepcion;
         aP7_TTBUS2_EstadoEnvio=this.AV28TTBUS2_EstadoEnvio;
         aP8_TTBUS2_MotivoEnvio=this.AV17TTBUS2_MotivoEnvio;
         aP9_TTBUS2_Observaciones=this.AV18TTBUS2_Observaciones;
         aP10_Modo=this.AV16Modo;
         aP11_USUARIO=this.AV31USUARIO;
         aP12_TTBUS2_PlazoRecepcion=this.AV37TTBUS2_PlazoRecepcion;
         return AV37TTBUS2_PlazoRecepcion ;
      }

      public void executeSubmit( ref int aP0_TTBUS2_IdBien ,
                                 ref short aP1_TTBUS2_CodPosDesde ,
                                 ref String aP2_TTBUS2_RespDesde ,
                                 ref DateTime aP3_TTBUS2_FechaEnvio ,
                                 ref short aP4_TTBUS2_CodPosHacia ,
                                 ref String aP5_TTBUS2_RespHacia ,
                                 ref DateTime aP6_TTBUS2_FechaRecepcion ,
                                 ref short aP7_TTBUS2_EstadoEnvio ,
                                 ref String aP8_TTBUS2_MotivoEnvio ,
                                 ref String aP9_TTBUS2_Observaciones ,
                                 ref String aP10_Modo ,
                                 ref String aP11_USUARIO ,
                                 ref DateTime aP12_TTBUS2_PlazoRecepcion )
      {
         pttbus000_1 objpttbus000_1;
         objpttbus000_1 = new pttbus000_1();
         objpttbus000_1.AV19TTBUS2_IdBien = aP0_TTBUS2_IdBien;
         objpttbus000_1.AV35TTBUS2_CodPosDesde = aP1_TTBUS2_CodPosDesde;
         objpttbus000_1.AV22TTBUS2_RespDesde = aP2_TTBUS2_RespDesde;
         objpttbus000_1.AV23TTBUS2_FechaEnvio = aP3_TTBUS2_FechaEnvio;
         objpttbus000_1.AV34TTBUS2_CodPosHacia = aP4_TTBUS2_CodPosHacia;
         objpttbus000_1.AV26TTBUS2_RespHacia = aP5_TTBUS2_RespHacia;
         objpttbus000_1.AV27TTBUS2_FechaRecepcion = aP6_TTBUS2_FechaRecepcion;
         objpttbus000_1.AV28TTBUS2_EstadoEnvio = aP7_TTBUS2_EstadoEnvio;
         objpttbus000_1.AV17TTBUS2_MotivoEnvio = aP8_TTBUS2_MotivoEnvio;
         objpttbus000_1.AV18TTBUS2_Observaciones = aP9_TTBUS2_Observaciones;
         objpttbus000_1.AV16Modo = aP10_Modo;
         objpttbus000_1.AV31USUARIO = aP11_USUARIO;
         objpttbus000_1.AV37TTBUS2_PlazoRecepcion = aP12_TTBUS2_PlazoRecepcion;
         objpttbus000_1.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpttbus000_1.executePrivateCatch ));
         aP0_TTBUS2_IdBien=this.AV19TTBUS2_IdBien;
         aP1_TTBUS2_CodPosDesde=this.AV35TTBUS2_CodPosDesde;
         aP2_TTBUS2_RespDesde=this.AV22TTBUS2_RespDesde;
         aP3_TTBUS2_FechaEnvio=this.AV23TTBUS2_FechaEnvio;
         aP4_TTBUS2_CodPosHacia=this.AV34TTBUS2_CodPosHacia;
         aP5_TTBUS2_RespHacia=this.AV26TTBUS2_RespHacia;
         aP6_TTBUS2_FechaRecepcion=this.AV27TTBUS2_FechaRecepcion;
         aP7_TTBUS2_EstadoEnvio=this.AV28TTBUS2_EstadoEnvio;
         aP8_TTBUS2_MotivoEnvio=this.AV17TTBUS2_MotivoEnvio;
         aP9_TTBUS2_Observaciones=this.AV18TTBUS2_Observaciones;
         aP10_Modo=this.AV16Modo;
         aP11_USUARIO=this.AV31USUARIO;
         aP12_TTBUS2_PlazoRecepcion=this.AV37TTBUS2_PlazoRecepcion;
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
         if ( StringUtil.StrCmp(AV16Modo, "INS") == 0 )
         {
            /*
               INSERT RECORD ON TABLE TTBUS002

            */
            A22TTBUS2_IdBien = AV19TTBUS2_IdBien ;
            A48TTBUS2_CodPosDesde = AV35TTBUS2_CodPosDesde ;
            A24TTBUS2_RespDesde = AV31USUARIO ;
            A45TTBUS2_FechaEnvio = AV23TTBUS2_FechaEnvio ;
            A49TTBUS2_CodPosHacia = AV34TTBUS2_CodPosHacia ;
            A25TTBUS2_RespHacia = AV26TTBUS2_RespHacia ;
            A46TTBUS2_FechaRecepcion = AV27TTBUS2_FechaRecepcion ;
            n46TTBUS2_FechaRecepcion = false ;
            A26TTBUS2_EstadoEnvio = AV28TTBUS2_EstadoEnvio ;
            A47TTBUS2_MotivoEnvio = AV17TTBUS2_MotivoEnvio ;
            A87TTBUS2_Observaciones = AV18TTBUS2_Observaciones ;
            n87TTBUS2_Observaciones = false ;
            A77TTBUS2_PlazoRecepcion = AV37TTBUS2_PlazoRecepcion ;
            n77TTBUS2_PlazoRecepcion = false ;
            /* Using cursor P000C2 */
            pr_default.execute(0, new Object[] {A22TTBUS2_IdBien, A48TTBUS2_CodPosDesde, A24TTBUS2_RespDesde, A45TTBUS2_FechaEnvio, A49TTBUS2_CodPosHacia, A25TTBUS2_RespHacia, n46TTBUS2_FechaRecepcion, A46TTBUS2_FechaRecepcion, A26TTBUS2_EstadoEnvio, A47TTBUS2_MotivoEnvio, n87TTBUS2_Observaciones, A87TTBUS2_Observaciones, n77TTBUS2_PlazoRecepcion, A77TTBUS2_PlazoRecepcion});
            pr_default.close(0);
            /* Retrieving last key number assigned */
            /* Using cursor P000C3 */
            pr_default.execute(1);
            A52TTBUS2_IdMovimiento = P000C3_A52TTBUS2_IdMovimiento[0] ;
            n52TTBUS2_IdMovimiento = P000C3_n52TTBUS2_IdMovimiento[0] ;
            pr_default.close(1);
            if ( (pr_default.getStatus(0) == 1) )
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
         }
         if ( StringUtil.StrCmp(AV16Modo, "UPD") == 0 )
         {
            /*
               INSERT RECORD ON TABLE TTBUS002

            */
            A22TTBUS2_IdBien = AV19TTBUS2_IdBien ;
            A48TTBUS2_CodPosDesde = AV35TTBUS2_CodPosDesde ;
            A24TTBUS2_RespDesde = AV22TTBUS2_RespDesde ;
            A45TTBUS2_FechaEnvio = AV23TTBUS2_FechaEnvio ;
            A49TTBUS2_CodPosHacia = AV34TTBUS2_CodPosHacia ;
            A25TTBUS2_RespHacia = AV26TTBUS2_RespHacia ;
            A46TTBUS2_FechaRecepcion = AV27TTBUS2_FechaRecepcion ;
            n46TTBUS2_FechaRecepcion = false ;
            A26TTBUS2_EstadoEnvio = AV28TTBUS2_EstadoEnvio ;
            A47TTBUS2_MotivoEnvio = AV17TTBUS2_MotivoEnvio ;
            A87TTBUS2_Observaciones = AV18TTBUS2_Observaciones ;
            n87TTBUS2_Observaciones = false ;
            A77TTBUS2_PlazoRecepcion = AV37TTBUS2_PlazoRecepcion ;
            n77TTBUS2_PlazoRecepcion = false ;
            /* Using cursor P000C4 */
            pr_default.execute(2, new Object[] {A22TTBUS2_IdBien, A48TTBUS2_CodPosDesde, A24TTBUS2_RespDesde, A45TTBUS2_FechaEnvio, A49TTBUS2_CodPosHacia, A25TTBUS2_RespHacia, n46TTBUS2_FechaRecepcion, A46TTBUS2_FechaRecepcion, A26TTBUS2_EstadoEnvio, A47TTBUS2_MotivoEnvio, n87TTBUS2_Observaciones, A87TTBUS2_Observaciones, n77TTBUS2_PlazoRecepcion, A77TTBUS2_PlazoRecepcion});
            pr_default.close(2);
            /* Retrieving last key number assigned */
            /* Using cursor P000C5 */
            pr_default.execute(3);
            A52TTBUS2_IdMovimiento = P000C5_A52TTBUS2_IdMovimiento[0] ;
            n52TTBUS2_IdMovimiento = P000C5_n52TTBUS2_IdMovimiento[0] ;
            pr_default.close(3);
            if ( (pr_default.getStatus(2) == 1) )
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
            /* Using cursor P000C6 */
            pr_default.execute(4);
            while ( (pr_default.getStatus(4) != 101) )
            {
               A52TTBUS2_IdMovimiento = P000C6_A52TTBUS2_IdMovimiento[0] ;
               n52TTBUS2_IdMovimiento = P000C6_n52TTBUS2_IdMovimiento[0] ;
               AV30TTBUS2_IdMovimiento = A52TTBUS2_IdMovimiento ;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(4);
            }
            pr_default.close(4);
            /* Optimized UPDATE. */
            /* Using cursor P000C7 */
            pr_default.execute(5, new Object[] {AV19TTBUS2_IdBien});
            pr_default.close(5);
            /* End optimized UPDATE. */
            new pttbus000_9(context ).execute( ref  AV30TTBUS2_IdMovimiento) ;
         }
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PTTBUS000_1");
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
         A24TTBUS2_RespDesde = "" ;
         A45TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         A25TTBUS2_RespHacia = "" ;
         A46TTBUS2_FechaRecepcion = (DateTime)(DateTime.MinValue) ;
         A47TTBUS2_MotivoEnvio = "" ;
         A87TTBUS2_Observaciones = "" ;
         A77TTBUS2_PlazoRecepcion = DateTime.MinValue ;
         scmdbuf = "" ;
         P000C3_A52TTBUS2_IdMovimiento = new long[1] ;
         P000C3_n52TTBUS2_IdMovimiento = new bool[] {false} ;
         Gx_emsg = "" ;
         P000C5_A52TTBUS2_IdMovimiento = new long[1] ;
         P000C5_n52TTBUS2_IdMovimiento = new bool[] {false} ;
         P000C6_A52TTBUS2_IdMovimiento = new long[1] ;
         P000C6_n52TTBUS2_IdMovimiento = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pttbus000_1__default(),
            new Object[][] {
                new Object[] {
               }
               , new Object[] {
               P000C3_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               }
               , new Object[] {
               P000C5_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               P000C6_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV35TTBUS2_CodPosDesde ;
      private short AV34TTBUS2_CodPosHacia ;
      private short AV28TTBUS2_EstadoEnvio ;
      private short A48TTBUS2_CodPosDesde ;
      private short A49TTBUS2_CodPosHacia ;
      private short A26TTBUS2_EstadoEnvio ;
      private int AV19TTBUS2_IdBien ;
      private int GX_INS5 ;
      private int A22TTBUS2_IdBien ;
      private long A52TTBUS2_IdMovimiento ;
      private long AV30TTBUS2_IdMovimiento ;
      private String AV22TTBUS2_RespDesde ;
      private String AV26TTBUS2_RespHacia ;
      private String AV16Modo ;
      private String AV31USUARIO ;
      private String A24TTBUS2_RespDesde ;
      private String A25TTBUS2_RespHacia ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime AV23TTBUS2_FechaEnvio ;
      private DateTime AV27TTBUS2_FechaRecepcion ;
      private DateTime A45TTBUS2_FechaEnvio ;
      private DateTime A46TTBUS2_FechaRecepcion ;
      private DateTime AV37TTBUS2_PlazoRecepcion ;
      private DateTime A77TTBUS2_PlazoRecepcion ;
      private bool n46TTBUS2_FechaRecepcion ;
      private bool n87TTBUS2_Observaciones ;
      private bool n77TTBUS2_PlazoRecepcion ;
      private bool n52TTBUS2_IdMovimiento ;
      private String AV17TTBUS2_MotivoEnvio ;
      private String AV18TTBUS2_Observaciones ;
      private String A47TTBUS2_MotivoEnvio ;
      private String A87TTBUS2_Observaciones ;
      private IGxDataStore dsDefault ;
      private int aP0_TTBUS2_IdBien ;
      private short aP1_TTBUS2_CodPosDesde ;
      private String aP2_TTBUS2_RespDesde ;
      private DateTime aP3_TTBUS2_FechaEnvio ;
      private short aP4_TTBUS2_CodPosHacia ;
      private String aP5_TTBUS2_RespHacia ;
      private DateTime aP6_TTBUS2_FechaRecepcion ;
      private short aP7_TTBUS2_EstadoEnvio ;
      private String aP8_TTBUS2_MotivoEnvio ;
      private String aP9_TTBUS2_Observaciones ;
      private String aP10_Modo ;
      private String aP11_USUARIO ;
      private DateTime aP12_TTBUS2_PlazoRecepcion ;
      private IDataStoreProvider pr_default ;
      private long[] P000C3_A52TTBUS2_IdMovimiento ;
      private bool[] P000C3_n52TTBUS2_IdMovimiento ;
      private long[] P000C5_A52TTBUS2_IdMovimiento ;
      private bool[] P000C5_n52TTBUS2_IdMovimiento ;
      private long[] P000C6_A52TTBUS2_IdMovimiento ;
      private bool[] P000C6_n52TTBUS2_IdMovimiento ;
   }

   public class pttbus000_1__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new UpdateCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new UpdateCursor(def[5])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000C2 ;
          prmP000C2 = new Object[] {
          new Object[] {"@TTBUS2_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS2_CodPosDesde",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS2_RespDesde",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS2_FechaEnvio",SqlDbType.DateTime,10,5} ,
          new Object[] {"@TTBUS2_CodPosHacia",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS2_RespHacia",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS2_FechaRecepcion",SqlDbType.DateTime,8,5} ,
          new Object[] {"@TTBUS2_EstadoEnvio",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS2_MotivoEnvio",SqlDbType.VarChar,100,0} ,
          new Object[] {"@TTBUS2_Observaciones",SqlDbType.VarChar,400,0} ,
          new Object[] {"@TTBUS2_PlazoRecepcion",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmP000C3 ;
          prmP000C3 = new Object[] {
          } ;
          Object[] prmP000C4 ;
          prmP000C4 = new Object[] {
          new Object[] {"@TTBUS2_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS2_CodPosDesde",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS2_RespDesde",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS2_FechaEnvio",SqlDbType.DateTime,10,5} ,
          new Object[] {"@TTBUS2_CodPosHacia",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS2_RespHacia",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS2_FechaRecepcion",SqlDbType.DateTime,8,5} ,
          new Object[] {"@TTBUS2_EstadoEnvio",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS2_MotivoEnvio",SqlDbType.VarChar,100,0} ,
          new Object[] {"@TTBUS2_Observaciones",SqlDbType.VarChar,400,0} ,
          new Object[] {"@TTBUS2_PlazoRecepcion",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmP000C5 ;
          prmP000C5 = new Object[] {
          } ;
          Object[] prmP000C6 ;
          prmP000C6 = new Object[] {
          } ;
          Object[] prmP000C7 ;
          prmP000C7 = new Object[] {
          new Object[] {"@AV19TTBUS2_IdBien",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000C2", "INSERT INTO [TTBUS002] ([TTBUS2_IdBien], [TTBUS2_CodPosDesde], [TTBUS2_RespDesde], [TTBUS2_FechaEnvio], [TTBUS2_CodPosHacia], [TTBUS2_RespHacia], [TTBUS2_FechaRecepcion], [TTBUS2_EstadoEnvio], [TTBUS2_MotivoEnvio], [TTBUS2_Observaciones], [TTBUS2_PlazoRecepcion], [TTBUS2_MotivoCancelacion]) VALUES (@TTBUS2_IdBien, @TTBUS2_CodPosDesde, @TTBUS2_RespDesde, @TTBUS2_FechaEnvio, @TTBUS2_CodPosHacia, @TTBUS2_RespHacia, @TTBUS2_FechaRecepcion, @TTBUS2_EstadoEnvio, @TTBUS2_MotivoEnvio, @TTBUS2_Observaciones, @TTBUS2_PlazoRecepcion, '')", GxErrorMask.GX_NOMASK,prmP000C2)
             ,new CursorDef("P000C3", "SELECT Ident_Current('[TTBUS002]') ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000C3,1,0,true,false )
             ,new CursorDef("P000C4", "INSERT INTO [TTBUS002] ([TTBUS2_IdBien], [TTBUS2_CodPosDesde], [TTBUS2_RespDesde], [TTBUS2_FechaEnvio], [TTBUS2_CodPosHacia], [TTBUS2_RespHacia], [TTBUS2_FechaRecepcion], [TTBUS2_EstadoEnvio], [TTBUS2_MotivoEnvio], [TTBUS2_Observaciones], [TTBUS2_PlazoRecepcion], [TTBUS2_MotivoCancelacion]) VALUES (@TTBUS2_IdBien, @TTBUS2_CodPosDesde, @TTBUS2_RespDesde, @TTBUS2_FechaEnvio, @TTBUS2_CodPosHacia, @TTBUS2_RespHacia, @TTBUS2_FechaRecepcion, @TTBUS2_EstadoEnvio, @TTBUS2_MotivoEnvio, @TTBUS2_Observaciones, @TTBUS2_PlazoRecepcion, '')", GxErrorMask.GX_NOMASK,prmP000C4)
             ,new CursorDef("P000C5", "SELECT Ident_Current('[TTBUS002]') ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000C5,1,0,true,false )
             ,new CursorDef("P000C6", "SELECT TOP 1 [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) ORDER BY [TTBUS2_IdMovimiento] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000C6,1,0,false,true )
             ,new CursorDef("P000C7", "UPDATE [TTBUS000] SET [TTBUS_Estado]=2, [TTBUS_CodPosicion]=999, [TTBUS_DesPosicion]='SIN ASIGNAR POR CAMBIO DE POSICIÓN'  WHERE [TTBUS_Id] = @AV19TTBUS2_IdBien", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000C7)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                break;
             case 3 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                break;
             case 4 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(7, (DateTime)parms[7]);
                }
                stmt.SetParameter(8, (short)parms[8]);
                stmt.SetParameter(9, (String)parms[9]);
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 10 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 11 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(11, (DateTime)parms[13]);
                }
                break;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(7, (DateTime)parms[7]);
                }
                stmt.SetParameter(8, (short)parms[8]);
                stmt.SetParameter(9, (String)parms[9]);
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 10 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 11 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(11, (DateTime)parms[13]);
                }
                break;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
