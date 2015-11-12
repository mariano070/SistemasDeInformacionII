/*
               File: PTBUS150
        Description: Alta masiva de bienes de uso (trazabilidad)
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:36.42
       Program type: Main program
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
using GeneXus.Office;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class aptbus150 : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
   {
      public override void webExecute( )
      {
         context.SetTheme("Modern");
         initialize();
         if ( nGotPars == 0 )
         {
            entryPointCalled = false ;
            gxfirstwebparm = GetNextPar( ) ;
         }
         executePrivate();
         cleanup();
      }

      public aptbus150( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public aptbus150( IGxContext context )
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

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         aptbus150 objaptbus150;
         objaptbus150 = new aptbus150();
         objaptbus150.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objaptbus150.executePrivateCatch ));
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
         AV8NOMBRE_ARCHIVO = "C:\\inetpub\\wwwroot\\rpt\\Importar_Trazabilidad.xls" ;
         AV9Planilla.Open(AV8NOMBRE_ARCHIVO);
         AV10FILA = 2 ;
         if ( AV9Planilla.ErrCode != 0 )
         {
            AV13cod = AV9Planilla.ErrCode ;
            AV14des = AV9Planilla.ErrDescription ;
         }
         else
         {
            while ( StringUtil.StrCmp(AV9Planilla.get_Cells(AV10FILA, 1, 1, 1).Text, "") != 0 )
            {
               AV15TTBUS_Descripcion = StringUtil.Trim( AV9Planilla.get_Cells(AV10FILA, 1, 1, 1).Text) ;
               AV16BUS_EMP = StringUtil.Trim( AV9Planilla.get_Cells(AV10FILA, 2, 1, 1).Text) ;
               AV17BUS_RUB = (short)(AV9Planilla.get_Cells(AV10FILA, 3, 1, 1).Number) ;
               AV18BUS_COD = (short)(AV9Planilla.get_Cells(AV10FILA, 4, 1, 1).Number) ;
               AV19BUS_PAR = (short)(AV9Planilla.get_Cells(AV10FILA, 5, 1, 1).Number) ;
               AV20HARDWARE_ID = (short)(AV9Planilla.get_Cells(AV10FILA, 6, 1, 1).Number) ;
               AV21TTBUS_FechaCarga = DateTimeUtil.ResetTime(AV9Planilla.get_Cells(AV10FILA, 7, 1, 1).Date) ;
               AV22TTBUS_Estado = 1 ;
               AV23TTBUS_CodProveedor = (int)(AV9Planilla.get_Cells(AV10FILA, 9, 1, 1).Number) ;
               AV24TTBUS_CucProveedor = (int)(AV9Planilla.get_Cells(AV10FILA, 10, 1, 1).Number) ;
               AV25TTBUS_Alquilado = (short)(AV9Planilla.get_Cells(AV10FILA, 11, 1, 1).Number) ;
               AV26TTBUS_CodPosicion = (short)(AV9Planilla.get_Cells(AV10FILA, 12, 1, 1).Number) ;
               AV27TTBUS_DesPosicion = StringUtil.Trim( AV9Planilla.get_Cells(AV10FILA, 13, 1, 1).Text) ;
               AV28TTBUS_RubroBien = (short)(AV9Planilla.get_Cells(AV10FILA, 14, 1, 1).Number) ;
               AV29TTBUS_UsuarioAlta = StringUtil.Trim( AV9Planilla.get_Cells(AV10FILA, 15, 1, 1).Text) ;
               AV30TTBUS_MaquinaAlta = StringUtil.Trim( AV9Planilla.get_Cells(AV10FILA, 16, 1, 1).Text) ;
               AV32IdIdentificador = (int)(AV9Planilla.get_Cells(AV10FILA, 17, 1, 1).Number) ;
               AV31NumeroIdentificador = StringUtil.Trim( AV9Planilla.get_Cells(AV10FILA, 18, 1, 1).Text) ;
               /*
                  INSERT RECORD ON TABLE TTBUS000

               */
               A12TTBUS_Descripcion = AV15TTBUS_Descripcion ;
               A8BUS_EMP = AV16BUS_EMP ;
               n8BUS_EMP = false ;
               A1BUS_RUB = AV17BUS_RUB ;
               n1BUS_RUB = false ;
               A3BUS_COD = AV18BUS_COD ;
               n3BUS_COD = false ;
               A4BUS_PAR = AV19BUS_PAR ;
               n4BUS_PAR = false ;
               A10HARDWARE_ID = AV20HARDWARE_ID ;
               n10HARDWARE_ID = false ;
               A13TTBUS_FechaCarga = AV21TTBUS_FechaCarga ;
               A23TTBUS_Estado = AV22TTBUS_Estado ;
               A27TTBUS_CodProveedor = AV23TTBUS_CodProveedor ;
               n27TTBUS_CodProveedor = false ;
               A73TTBUS_CucProveedor = AV24TTBUS_CucProveedor ;
               n73TTBUS_CucProveedor = false ;
               A29TTBUS_Alquilado = AV25TTBUS_Alquilado ;
               A37TTBUS_CodPosicion = AV26TTBUS_CodPosicion ;
               A38TTBUS_DesPosicion = AV27TTBUS_DesPosicion ;
               A17TTBUS_RubroBien = AV28TTBUS_RubroBien ;
               A75TTBUS_UsuarioAlta = AV29TTBUS_UsuarioAlta ;
               A76TTBUS_MaquinaAlta = AV30TTBUS_MaquinaAlta ;
               /* Using cursor P001X2 */
               pr_default.execute(0, new Object[] {A12TTBUS_Descripcion, n8BUS_EMP, A8BUS_EMP, n1BUS_RUB, A1BUS_RUB, n3BUS_COD, A3BUS_COD, n4BUS_PAR, A4BUS_PAR, n10HARDWARE_ID, A10HARDWARE_ID, A13TTBUS_FechaCarga, A23TTBUS_Estado, n27TTBUS_CodProveedor, A27TTBUS_CodProveedor, n73TTBUS_CucProveedor, A73TTBUS_CucProveedor, A29TTBUS_Alquilado, A37TTBUS_CodPosicion, A38TTBUS_DesPosicion, A17TTBUS_RubroBien, A75TTBUS_UsuarioAlta, A76TTBUS_MaquinaAlta});
               pr_default.close(0);
               /* Retrieving last key number assigned */
               /* Using cursor P001X3 */
               pr_default.execute(1);
               A11TTBUS_Id = P001X3_A11TTBUS_Id[0] ;
               n11TTBUS_Id = P001X3_n11TTBUS_Id[0] ;
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
               AV11TTBUS_Id = A11TTBUS_Id ;
               /*
                  INSERT RECORD ON TABLE TTBUS000Identificadores

               */
               A11TTBUS_Id = AV11TTBUS_Id ;
               n11TTBUS_Id = false ;
               A14IdIdentificador = AV32IdIdentificador ;
               A15NumeroIdentificador = AV31NumeroIdentificador ;
               /* Using cursor P001X4 */
               pr_default.execute(2, new Object[] {n11TTBUS_Id, A11TTBUS_Id, A14IdIdentificador, A15NumeroIdentificador});
               pr_default.close(2);
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
               /*
                  INSERT RECORD ON TABLE TTBUS002

               */
               A22TTBUS2_IdBien = AV11TTBUS_Id ;
               A48TTBUS2_CodPosDesde = 0 ;
               A24TTBUS2_RespDesde = AV29TTBUS_UsuarioAlta ;
               A45TTBUS2_FechaEnvio = DateTimeUtil.ResetTime( AV21TTBUS_FechaCarga ) ;
               A49TTBUS2_CodPosHacia = AV26TTBUS_CodPosicion ;
               A25TTBUS2_RespHacia = AV29TTBUS_UsuarioAlta ;
               A46TTBUS2_FechaRecepcion = DateTimeUtil.ResetTime( AV21TTBUS_FechaCarga ) ;
               n46TTBUS2_FechaRecepcion = false ;
               A26TTBUS2_EstadoEnvio = 2 ;
               A47TTBUS2_MotivoEnvio = "" ;
               A87TTBUS2_Observaciones = "INGRESO DEL BIEN AL SISTEMA" ;
               n87TTBUS2_Observaciones = false ;
               /* Using cursor P001X5 */
               pr_default.execute(3, new Object[] {A22TTBUS2_IdBien, A48TTBUS2_CodPosDesde, A24TTBUS2_RespDesde, A45TTBUS2_FechaEnvio, A49TTBUS2_CodPosHacia, A25TTBUS2_RespHacia, n46TTBUS2_FechaRecepcion, A46TTBUS2_FechaRecepcion, A26TTBUS2_EstadoEnvio, A47TTBUS2_MotivoEnvio, n87TTBUS2_Observaciones, A87TTBUS2_Observaciones});
               pr_default.close(3);
               /* Retrieving last key number assigned */
               /* Using cursor P001X6 */
               pr_default.execute(4);
               A52TTBUS2_IdMovimiento = P001X6_A52TTBUS2_IdMovimiento[0] ;
               n52TTBUS2_IdMovimiento = P001X6_n52TTBUS2_IdMovimiento[0] ;
               pr_default.close(4);
               if ( (pr_default.getStatus(3) == 1) )
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
               /*
                  INSERT RECORD ON TABLE TTBUS003

               */
               A105TTBUS3_IdBien = AV11TTBUS_Id ;
               A106TTBUS3_NroAsoc = 1 ;
               A107TTBUS3_Sist = 1 ;
               A108TTBUS3_HdwId = AV20HARDWARE_ID ;
               n108TTBUS3_HdwId = false ;
               A109TTBUS3_BusEmp = AV16BUS_EMP ;
               n109TTBUS3_BusEmp = false ;
               A110TTBUS3_BusRub = AV17BUS_RUB ;
               n110TTBUS3_BusRub = false ;
               A111TTBUS3_BusCod = AV18BUS_COD ;
               n111TTBUS3_BusCod = false ;
               A112TTBUS3_BusPar = AV19BUS_PAR ;
               n112TTBUS3_BusPar = false ;
               A113TTBUS3_Usuario = AV29TTBUS_UsuarioAlta ;
               A114TTBUS3_FechaAsoc = DateTimeUtil.ResetTime( AV21TTBUS_FechaCarga ) ;
               A115TTBUS3_MaquinaAsoc = AV30TTBUS_MaquinaAlta ;
               /* Using cursor P001X7 */
               pr_default.execute(5, new Object[] {A105TTBUS3_IdBien, A106TTBUS3_NroAsoc, A107TTBUS3_Sist, n108TTBUS3_HdwId, A108TTBUS3_HdwId, n109TTBUS3_BusEmp, A109TTBUS3_BusEmp, n110TTBUS3_BusRub, A110TTBUS3_BusRub, n111TTBUS3_BusCod, A111TTBUS3_BusCod, n112TTBUS3_BusPar, A112TTBUS3_BusPar, A113TTBUS3_Usuario, A114TTBUS3_FechaAsoc, A115TTBUS3_MaquinaAsoc});
               pr_default.close(5);
               if ( (pr_default.getStatus(5) == 1) )
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
               /* Optimized UPDATE. */
               /* Using cursor P001X8 */
               pr_default.execute(6, new Object[] {AV11TTBUS_Id, AV20HARDWARE_ID});
               pr_default.close(6);
               /* End optimized UPDATE. */
               /* Optimized UPDATE. */
               /* Using cursor P001X9 */
               pr_default.execute(7, new Object[] {AV11TTBUS_Id, AV16BUS_EMP, AV17BUS_RUB, AV18BUS_COD, AV19BUS_PAR});
               pr_default.close(7);
               /* End optimized UPDATE. */
               AV10FILA = (int)(AV10FILA+1) ;
            }
         }
         AV9Planilla.Close();
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
         {
            context.Redirect( context.wjLoc );
            context.wjLoc = "" ;
         }
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PTBUS150");
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
         gxfirstwebparm = "" ;
         AV8NOMBRE_ARCHIVO = "" ;
         AV9Planilla = new ExcelDocumentI();
         AV14des = "" ;
         AV15TTBUS_Descripcion = "" ;
         AV16BUS_EMP = "" ;
         AV21TTBUS_FechaCarga = DateTime.MinValue ;
         AV22TTBUS_Estado = 1 ;
         AV27TTBUS_DesPosicion = "" ;
         AV29TTBUS_UsuarioAlta = "" ;
         AV30TTBUS_MaquinaAlta = "" ;
         AV31NumeroIdentificador = "" ;
         A12TTBUS_Descripcion = "" ;
         A8BUS_EMP = "" ;
         A13TTBUS_FechaCarga = DateTime.MinValue ;
         A38TTBUS_DesPosicion = "" ;
         A75TTBUS_UsuarioAlta = "" ;
         A76TTBUS_MaquinaAlta = "" ;
         scmdbuf = "" ;
         P001X3_A11TTBUS_Id = new int[1] ;
         P001X3_n11TTBUS_Id = new bool[] {false} ;
         Gx_emsg = "" ;
         A15NumeroIdentificador = "" ;
         A24TTBUS2_RespDesde = "" ;
         A45TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         A25TTBUS2_RespHacia = "" ;
         A46TTBUS2_FechaRecepcion = (DateTime)(DateTime.MinValue) ;
         A47TTBUS2_MotivoEnvio = "" ;
         A87TTBUS2_Observaciones = "" ;
         P001X6_A52TTBUS2_IdMovimiento = new long[1] ;
         P001X6_n52TTBUS2_IdMovimiento = new bool[] {false} ;
         A109TTBUS3_BusEmp = "" ;
         A113TTBUS3_Usuario = "" ;
         A114TTBUS3_FechaAsoc = (DateTime)(DateTime.MinValue) ;
         A115TTBUS3_MaquinaAsoc = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.aptbus150__default(),
            new Object[][] {
                new Object[] {
               }
               , new Object[] {
               P001X3_A11TTBUS_Id
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               P001X6_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short AV13cod ;
      private short AV17BUS_RUB ;
      private short AV18BUS_COD ;
      private short AV19BUS_PAR ;
      private short AV20HARDWARE_ID ;
      private short AV22TTBUS_Estado ;
      private short AV25TTBUS_Alquilado ;
      private short AV26TTBUS_CodPosicion ;
      private short AV28TTBUS_RubroBien ;
      private short A1BUS_RUB ;
      private short A3BUS_COD ;
      private short A4BUS_PAR ;
      private short A10HARDWARE_ID ;
      private short A23TTBUS_Estado ;
      private short A29TTBUS_Alquilado ;
      private short A37TTBUS_CodPosicion ;
      private short A17TTBUS_RubroBien ;
      private short A48TTBUS2_CodPosDesde ;
      private short A49TTBUS2_CodPosHacia ;
      private short A26TTBUS2_EstadoEnvio ;
      private short A107TTBUS3_Sist ;
      private short A108TTBUS3_HdwId ;
      private short A110TTBUS3_BusRub ;
      private short A111TTBUS3_BusCod ;
      private short A112TTBUS3_BusPar ;
      private int AV10FILA ;
      private int AV23TTBUS_CodProveedor ;
      private int AV24TTBUS_CucProveedor ;
      private int AV32IdIdentificador ;
      private int GX_INS1 ;
      private int A27TTBUS_CodProveedor ;
      private int A73TTBUS_CucProveedor ;
      private int A11TTBUS_Id ;
      private int AV11TTBUS_Id ;
      private int GX_INS2 ;
      private int A14IdIdentificador ;
      private int GX_INS5 ;
      private int A22TTBUS2_IdBien ;
      private int GX_INS11 ;
      private int A105TTBUS3_IdBien ;
      private int A106TTBUS3_NroAsoc ;
      private int A104HDW_IDT ;
      private int A103BUS_IDT ;
      private long A52TTBUS2_IdMovimiento ;
      private String gxfirstwebparm ;
      private String AV8NOMBRE_ARCHIVO ;
      private String AV14des ;
      private String AV16BUS_EMP ;
      private String AV27TTBUS_DesPosicion ;
      private String AV29TTBUS_UsuarioAlta ;
      private String AV30TTBUS_MaquinaAlta ;
      private String A8BUS_EMP ;
      private String A38TTBUS_DesPosicion ;
      private String A75TTBUS_UsuarioAlta ;
      private String A76TTBUS_MaquinaAlta ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A24TTBUS2_RespDesde ;
      private String A25TTBUS2_RespHacia ;
      private String A109TTBUS3_BusEmp ;
      private String A113TTBUS3_Usuario ;
      private String A115TTBUS3_MaquinaAsoc ;
      private DateTime A45TTBUS2_FechaEnvio ;
      private DateTime A46TTBUS2_FechaRecepcion ;
      private DateTime A114TTBUS3_FechaAsoc ;
      private DateTime AV21TTBUS_FechaCarga ;
      private DateTime A13TTBUS_FechaCarga ;
      private bool entryPointCalled ;
      private bool n8BUS_EMP ;
      private bool n1BUS_RUB ;
      private bool n3BUS_COD ;
      private bool n4BUS_PAR ;
      private bool n10HARDWARE_ID ;
      private bool n27TTBUS_CodProveedor ;
      private bool n73TTBUS_CucProveedor ;
      private bool n11TTBUS_Id ;
      private bool n46TTBUS2_FechaRecepcion ;
      private bool n87TTBUS2_Observaciones ;
      private bool n52TTBUS2_IdMovimiento ;
      private bool n108TTBUS3_HdwId ;
      private bool n109TTBUS3_BusEmp ;
      private bool n110TTBUS3_BusRub ;
      private bool n111TTBUS3_BusCod ;
      private bool n112TTBUS3_BusPar ;
      private String AV15TTBUS_Descripcion ;
      private String AV31NumeroIdentificador ;
      private String A12TTBUS_Descripcion ;
      private String A15NumeroIdentificador ;
      private String A47TTBUS2_MotivoEnvio ;
      private String A87TTBUS2_Observaciones ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] P001X3_A11TTBUS_Id ;
      private bool[] P001X3_n11TTBUS_Id ;
      private long[] P001X6_A52TTBUS2_IdMovimiento ;
      private bool[] P001X6_n52TTBUS2_IdMovimiento ;
      private ExcelDocumentI AV9Planilla ;
   }

   public class aptbus150__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new UpdateCursor(def[2])
         ,new UpdateCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new UpdateCursor(def[5])
         ,new UpdateCursor(def[6])
         ,new UpdateCursor(def[7])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001X2 ;
          prmP001X2 = new Object[] {
          new Object[] {"@TTBUS_Descripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_PAR",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@HARDWARE_ID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TTBUS_FechaCarga",SqlDbType.DateTime,8,0} ,
          new Object[] {"@TTBUS_Estado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS_CodProveedor",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS_CucProveedor",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS_Alquilado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS_CodPosicion",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS_DesPosicion",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS_RubroBien",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TTBUS_UsuarioAlta",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS_MaquinaAlta",SqlDbType.Char,20,0}
          } ;
          Object[] prmP001X3 ;
          prmP001X3 = new Object[] {
          } ;
          Object[] prmP001X4 ;
          prmP001X4 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@IdIdentificador",SqlDbType.Int,8,0} ,
          new Object[] {"@NumeroIdentificador",SqlDbType.VarChar,80,0}
          } ;
          Object[] prmP001X5 ;
          prmP001X5 = new Object[] {
          new Object[] {"@TTBUS2_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS2_CodPosDesde",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS2_RespDesde",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS2_FechaEnvio",SqlDbType.DateTime,10,5} ,
          new Object[] {"@TTBUS2_CodPosHacia",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS2_RespHacia",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS2_FechaRecepcion",SqlDbType.DateTime,8,5} ,
          new Object[] {"@TTBUS2_EstadoEnvio",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS2_MotivoEnvio",SqlDbType.VarChar,100,0} ,
          new Object[] {"@TTBUS2_Observaciones",SqlDbType.VarChar,400,0}
          } ;
          Object[] prmP001X6 ;
          prmP001X6 = new Object[] {
          } ;
          Object[] prmP001X7 ;
          prmP001X7 = new Object[] {
          new Object[] {"@TTBUS3_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS3_NroAsoc",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS3_Sist",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@TTBUS3_HdwId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TTBUS3_BusEmp",SqlDbType.Char,1,0} ,
          new Object[] {"@TTBUS3_BusRub",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TTBUS3_BusCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TTBUS3_BusPar",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@TTBUS3_Usuario",SqlDbType.Char,16,0} ,
          new Object[] {"@TTBUS3_FechaAsoc",SqlDbType.DateTime,10,5} ,
          new Object[] {"@TTBUS3_MaquinaAsoc",SqlDbType.Char,20,0}
          } ;
          Object[] prmP001X8 ;
          prmP001X8 = new Object[] {
          new Object[] {"@HDW_IDT",SqlDbType.Int,8,0} ,
          new Object[] {"@AV20HARDWARE_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001X9 ;
          prmP001X9 = new Object[] {
          new Object[] {"@BUS_IDT",SqlDbType.Int,8,0} ,
          new Object[] {"@AV16BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@AV17BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV18BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV19BUS_PAR",SqlDbType.SmallInt,2,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001X2", "INSERT INTO [TTBUS000] ([TTBUS_Descripcion], [BUS_EMP], [BUS_RUB], [BUS_COD], [BUS_PAR], [HARDWARE_ID], [TTBUS_FechaCarga], [TTBUS_Estado], [TTBUS_CodProveedor], [TTBUS_CucProveedor], [TTBUS_Alquilado], [TTBUS_CodPosicion], [TTBUS_DesPosicion], [TTBUS_RubroBien], [TTBUS_UsuarioAlta], [TTBUS_MaquinaAlta], [TTBUS_DesProveedor], [TTBUS_ContDocu], [TTBUS_Empresa], [TTBUS_NroSerie], [TTBUS_FechaBaja], [TTBUS_MotivoBaja], [TTBUS_UsuarioBaja], [TTBUS_MaquinaBaja]) VALUES (@TTBUS_Descripcion, @BUS_EMP, @BUS_RUB, @BUS_COD, @BUS_PAR, @HARDWARE_ID, @TTBUS_FechaCarga, @TTBUS_Estado, @TTBUS_CodProveedor, @TTBUS_CucProveedor, @TTBUS_Alquilado, @TTBUS_CodPosicion, @TTBUS_DesPosicion, @TTBUS_RubroBien, @TTBUS_UsuarioAlta, @TTBUS_MaquinaAlta, '', convert(int, 0), convert(int, 0), '', convert( DATETIME, '17530101', 112 ), '', '', '')", GxErrorMask.GX_NOMASK,prmP001X2)
             ,new CursorDef("P001X3", "SELECT Ident_Current('[TTBUS000]') ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001X3,1,0,true,false )
             ,new CursorDef("P001X4", "INSERT INTO [TTBUS000Identificadores] ([TTBUS_Id], [IdIdentificador], [NumeroIdentificador]) VALUES (@TTBUS_Id, @IdIdentificador, @NumeroIdentificador)", GxErrorMask.GX_NOMASK,prmP001X4)
             ,new CursorDef("P001X5", "INSERT INTO [TTBUS002] ([TTBUS2_IdBien], [TTBUS2_CodPosDesde], [TTBUS2_RespDesde], [TTBUS2_FechaEnvio], [TTBUS2_CodPosHacia], [TTBUS2_RespHacia], [TTBUS2_FechaRecepcion], [TTBUS2_EstadoEnvio], [TTBUS2_MotivoEnvio], [TTBUS2_Observaciones], [TTBUS2_MotivoCancelacion], [TTBUS2_PlazoRecepcion]) VALUES (@TTBUS2_IdBien, @TTBUS2_CodPosDesde, @TTBUS2_RespDesde, @TTBUS2_FechaEnvio, @TTBUS2_CodPosHacia, @TTBUS2_RespHacia, @TTBUS2_FechaRecepcion, @TTBUS2_EstadoEnvio, @TTBUS2_MotivoEnvio, @TTBUS2_Observaciones, '', convert( DATETIME, '17530101', 112 ))", GxErrorMask.GX_NOMASK,prmP001X5)
             ,new CursorDef("P001X6", "SELECT Ident_Current('[TTBUS002]') ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001X6,1,0,true,false )
             ,new CursorDef("P001X7", "INSERT INTO [TTBUS003] ([TTBUS3_IdBien], [TTBUS3_NroAsoc], [TTBUS3_Sist], [TTBUS3_HdwId], [TTBUS3_BusEmp], [TTBUS3_BusRub], [TTBUS3_BusCod], [TTBUS3_BusPar], [TTBUS3_Usuario], [TTBUS3_FechaAsoc], [TTBUS3_MaquinaAsoc]) VALUES (@TTBUS3_IdBien, @TTBUS3_NroAsoc, @TTBUS3_Sist, @TTBUS3_HdwId, @TTBUS3_BusEmp, @TTBUS3_BusRub, @TTBUS3_BusCod, @TTBUS3_BusPar, @TTBUS3_Usuario, @TTBUS3_FechaAsoc, @TTBUS3_MaquinaAsoc)", GxErrorMask.GX_NOMASK,prmP001X7)
             ,new CursorDef("P001X8", "UPDATE [HARDWARE] SET [HDW_IDT]=@HDW_IDT  WHERE [HARDWARE_ID] = @AV20HARDWARE_ID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001X8)
             ,new CursorDef("P001X9", "UPDATE [BUS000] SET [BUS_IDT]=@BUS_IDT  WHERE [BUS_EMP] = @AV16BUS_EMP and [BUS_RUB] = @AV17BUS_RUB and [BUS_COD] = @AV18BUS_COD and [BUS_PAR] = @AV19BUS_PAR", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001X9)
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(5, (short)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 6 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(6, (short)parms[10]);
                }
                stmt.SetParameter(7, (DateTime)parms[11]);
                stmt.SetParameter(8, (short)parms[12]);
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 9 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(9, (int)parms[14]);
                }
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 10 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(10, (int)parms[16]);
                }
                stmt.SetParameter(11, (short)parms[17]);
                stmt.SetParameter(12, (short)parms[18]);
                stmt.SetParameter(13, (String)parms[19]);
                stmt.SetParameter(14, (short)parms[20]);
                stmt.SetParameter(15, (String)parms[21]);
                stmt.SetParameter(16, (String)parms[22]);
                break;
             case 2 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                stmt.SetParameter(3, (String)parms[3]);
                break;
             case 3 :
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
                break;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 5 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 6 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(6, (short)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 7 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(7, (short)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 8 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(8, (short)parms[12]);
                }
                stmt.SetParameter(9, (String)parms[13]);
                stmt.SetParameter(10, (DateTime)parms[14]);
                stmt.SetParameter(11, (String)parms[15]);
                break;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                break;
       }
    }

 }

}
