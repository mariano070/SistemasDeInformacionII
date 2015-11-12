/*
               File: PTBUS016_2
        Description: Listado de Bienes de Uso y sus Identificadores (en excel)
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/26/2014 11:46:56.81
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
   public class aptbus016_2 : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
   {
      public override void webExecute( )
      {
         context.SetTheme("Modern");
         initialize();
         if ( nGotPars == 0 )
         {
            entryPointCalled = false ;
            gxfirstwebparm = GetNextPar( ) ;
            if ( ! entryPointCalled )
            {
               AV40USUARIO = gxfirstwebparm ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV47TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  AV46TTBUS7_CodResp = GetNextPar( ) ;
               }
            }
         }
         executePrivate();
         cleanup();
      }

      public aptbus016_2( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public aptbus016_2( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_USUARIO ,
                           ref short aP1_TTBUS7_Pos ,
                           ref String aP2_TTBUS7_CodResp )
      {
         this.AV40USUARIO = aP0_USUARIO;
         this.AV47TTBUS7_Pos = aP1_TTBUS7_Pos;
         this.AV46TTBUS7_CodResp = aP2_TTBUS7_CodResp;
         initialize();
         executePrivate();
         aP0_USUARIO=this.AV40USUARIO;
         aP1_TTBUS7_Pos=this.AV47TTBUS7_Pos;
         aP2_TTBUS7_CodResp=this.AV46TTBUS7_CodResp;
      }

      public String executeUdp( ref String aP0_USUARIO ,
                                ref short aP1_TTBUS7_Pos )
      {
         this.AV40USUARIO = aP0_USUARIO;
         this.AV47TTBUS7_Pos = aP1_TTBUS7_Pos;
         this.AV46TTBUS7_CodResp = aP2_TTBUS7_CodResp;
         initialize();
         executePrivate();
         aP0_USUARIO=this.AV40USUARIO;
         aP1_TTBUS7_Pos=this.AV47TTBUS7_Pos;
         aP2_TTBUS7_CodResp=this.AV46TTBUS7_CodResp;
         return AV46TTBUS7_CodResp ;
      }

      public void executeSubmit( ref String aP0_USUARIO ,
                                 ref short aP1_TTBUS7_Pos ,
                                 ref String aP2_TTBUS7_CodResp )
      {
         aptbus016_2 objaptbus016_2;
         objaptbus016_2 = new aptbus016_2();
         objaptbus016_2.AV40USUARIO = aP0_USUARIO;
         objaptbus016_2.AV47TTBUS7_Pos = aP1_TTBUS7_Pos;
         objaptbus016_2.AV46TTBUS7_CodResp = aP2_TTBUS7_CodResp;
         objaptbus016_2.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objaptbus016_2.executePrivateCatch ));
         aP0_USUARIO=this.AV40USUARIO;
         aP1_TTBUS7_Pos=this.AV47TTBUS7_Pos;
         aP2_TTBUS7_CodResp=this.AV46TTBUS7_CodResp;
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
         AV17NOMBRE_REPORTE = "PlanillaBienesIdentificadores_" + StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( AV8AHORA)), 10, 0)) + StringUtil.PadL( StringUtil.Str( (decimal)(DateTimeUtil.Month( AV8AHORA)), 2, 0), 2, "0") + StringUtil.PadL( StringUtil.Str( (decimal)(DateTimeUtil.Day( AV8AHORA)), 2, 0), 2, "0") + StringUtil.Substring( Gx_time, 1, 2) + StringUtil.Substring( Gx_time, 4, 2) + StringUtil.Substring( Gx_time, 7, 2) + ".xls" ;
         AV54planilla_excel.Open(AV17NOMBRE_REPORTE);
         AV54planilla_excel.Clear();
         AV54planilla_excel.SelectSheet("Sheet1");
         AV54planilla_excel.RenameSheet("Datos Planilla");
         AV54planilla_excel.SelectSheet("Datos Planilla");
         AV54planilla_excel.get_Cells(1, 1, 1, 1).Text = "TRAZABILIDAD DE BIENES DE USO" ;
         AV54planilla_excel.get_Cells(1, 1, 1, 1).Size = 14 ;
         AV54planilla_excel.get_Cells(1, 1, 1, 1).Bold = 1 ;
         AV54planilla_excel.get_Cells(1, 1, 1, 1).Underline = 1 ;
         AV54planilla_excel.get_Cells(2, 1, 1, 1).Text = "PLANILLA DE BIENES DE USO Y SUS IDENTIFICADORES" ;
         AV54planilla_excel.get_Cells(2, 1, 1, 1).Size = 12 ;
         AV54planilla_excel.get_Cells(2, 1, 1, 1).Bold = 1 ;
         AV55FILA = 4 ;
         AV54planilla_excel.get_Cells(AV55FILA, 1, 1, 1).Text = "Nº Bien" ;
         AV54planilla_excel.get_Cells(AV55FILA, 2, 1, 1).Text = "Descripción" ;
         AV54planilla_excel.get_Cells(AV55FILA, 3, 1, 1).Text = "Alquilado" ;
         AV54planilla_excel.get_Cells(AV55FILA, 4, 1, 1).Text = "Tipo Identificador" ;
         AV54planilla_excel.get_Cells(AV55FILA, 5, 1, 1).Text = "Código de Identificador" ;
         AV55FILA = (int)(AV55FILA+1) ;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV47TTBUS7_Pos ,
                                              A37TTBUS_CodPosicion },
                                              new int[] {
                                              TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         });
         /* Using cursor P001E2 */
         pr_default.execute(0, new Object[] {AV47TTBUS7_Pos});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A35TTBUS7_CodResp = P001E2_A35TTBUS7_CodResp[0] ;
            n35TTBUS7_CodResp = P001E2_n35TTBUS7_CodResp[0] ;
            A37TTBUS_CodPosicion = P001E2_A37TTBUS_CodPosicion[0] ;
            A29TTBUS_Alquilado = P001E2_A29TTBUS_Alquilado[0] ;
            A12TTBUS_Descripcion = P001E2_A12TTBUS_Descripcion[0] ;
            A23TTBUS_Estado = P001E2_A23TTBUS_Estado[0] ;
            A11TTBUS_Id = P001E2_A11TTBUS_Id[0] ;
            A35TTBUS7_CodResp = P001E2_A35TTBUS7_CodResp[0] ;
            n35TTBUS7_CodResp = P001E2_n35TTBUS7_CodResp[0] ;
            AV24TTBUS_CodPosicion = A37TTBUS_CodPosicion ;
            AV23TTBUS_Alquilado = A29TTBUS_Alquilado ;
            AV28TTBUS_Id = A11TTBUS_Id ;
            AV50tTTBUS_Descripcion = A12TTBUS_Descripcion ;
            if ( StringUtil.StrCmp(StringUtil.Trim( AV46TTBUS7_CodResp), "") != 0 )
            {
               if ( A23TTBUS_Estado == 1 )
               {
                  /* Using cursor P001E3 */
                  pr_default.execute(1, new Object[] {AV24TTBUS_CodPosicion});
                  while ( (pr_default.getStatus(1) != 101) )
                  {
                     A33TTBUS7_Pos = P001E3_A33TTBUS7_Pos[0] ;
                     if ( StringUtil.StrCmp(A35TTBUS7_CodResp, AV46TTBUS7_CodResp) == 0 )
                     {
                        /* Execute user subroutine: S1173 */
                        S1173 ();
                        if ( returnInSub )
                        {
                           pr_default.close(1);
                           this.cleanup();
                           if (true) return;
                        }
                     }
                     /* Exiting from a For First loop. */
                     if (true) break;
                  }
                  pr_default.close(1);
               }
               else
               {
                  /* Using cursor P001E4 */
                  pr_default.execute(2, new Object[] {AV28TTBUS_Id});
                  while ( (pr_default.getStatus(2) != 101) )
                  {
                     A26TTBUS2_EstadoEnvio = P001E4_A26TTBUS2_EstadoEnvio[0] ;
                     A22TTBUS2_IdBien = P001E4_A22TTBUS2_IdBien[0] ;
                     A24TTBUS2_RespDesde = P001E4_A24TTBUS2_RespDesde[0] ;
                     A25TTBUS2_RespHacia = P001E4_A25TTBUS2_RespHacia[0] ;
                     A52TTBUS2_IdMovimiento = P001E4_A52TTBUS2_IdMovimiento[0] ;
                     if ( StringUtil.StrCmp(A24TTBUS2_RespDesde, AV46TTBUS7_CodResp) == 0 )
                     {
                        /* Execute user subroutine: S1173 */
                        S1173 ();
                        if ( returnInSub )
                        {
                           pr_default.close(2);
                           this.cleanup();
                           if (true) return;
                        }
                     }
                     else if ( StringUtil.StrCmp(A25TTBUS2_RespHacia, AV46TTBUS7_CodResp) == 0 )
                     {
                        /* Execute user subroutine: S1173 */
                        S1173 ();
                        if ( returnInSub )
                        {
                           pr_default.close(2);
                           this.cleanup();
                           if (true) return;
                        }
                     }
                     pr_default.readNext(2);
                  }
                  pr_default.close(2);
               }
            }
            else
            {
               /* Execute user subroutine: S1173 */
               S1173 ();
               if ( returnInSub )
               {
                  pr_default.close(0);
                  this.cleanup();
                  if (true) return;
               }
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV54planilla_excel.Save();
         AV54planilla_excel.Close();
         context.wjLoc = formatLink(AV17NOMBRE_REPORTE)  ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
         {
            context.Redirect( context.wjLoc );
            context.wjLoc = "" ;
         }
         this.cleanup();
      }

      protected void S1173( )
      {
         /* 'INFORME' Routine */
         AV10band = 0 ;
         new ptbus007(context ).execute( ref  AV10band,  AV28TTBUS_Id,  AV40USUARIO) ;
         if ( AV10band == 1 )
         {
            AV26TTBUS_Descripcion = AV50tTTBUS_Descripcion ;
            if ( AV23TTBUS_Alquilado == 1 )
            {
               AV9alquilado = "SI" ;
            }
            else if ( AV23TTBUS_Alquilado == 0 )
            {
               AV9alquilado = "NO" ;
            }
            AV33TTBUS2_IdBien = AV28TTBUS_Id ;
            AV54planilla_excel.get_Cells(AV55FILA, 1, 1, 1).Number = AV28TTBUS_Id ;
            AV54planilla_excel.get_Cells(AV55FILA, 2, 1, 1).Text = AV26TTBUS_Descripcion ;
            AV54planilla_excel.get_Cells(AV55FILA, 3, 1, 1).Text = AV9alquilado ;
            /* Using cursor P001E5 */
            pr_default.execute(3, new Object[] {AV33TTBUS2_IdBien});
            while ( (pr_default.getStatus(3) != 101) )
            {
               A21TTBUS5_DescIdentificador = P001E5_A21TTBUS5_DescIdentificador[0] ;
               n21TTBUS5_DescIdentificador = P001E5_n21TTBUS5_DescIdentificador[0] ;
               A11TTBUS_Id = P001E5_A11TTBUS_Id[0] ;
               A15NumeroIdentificador = P001E5_A15NumeroIdentificador[0] ;
               A14IdIdentificador = P001E5_A14IdIdentificador[0] ;
               A21TTBUS5_DescIdentificador = P001E5_A21TTBUS5_DescIdentificador[0] ;
               n21TTBUS5_DescIdentificador = P001E5_n21TTBUS5_DescIdentificador[0] ;
               AV51IdIdentificador = A14IdIdentificador ;
               AV53NumeroIdentificador = StringUtil.Trim( A15NumeroIdentificador) ;
               AV52TTBUS5_DescIdentificador = "" ;
               /* Using cursor P001E6 */
               pr_default.execute(4, new Object[] {AV51IdIdentificador});
               while ( (pr_default.getStatus(4) != 101) )
               {
                  A20TTBUS5_IdIdentificador = P001E6_A20TTBUS5_IdIdentificador[0] ;
                  AV52TTBUS5_DescIdentificador = StringUtil.Trim( A21TTBUS5_DescIdentificador) ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(4);
               AV54planilla_excel.get_Cells(AV55FILA, 4, 1, 1).Text = AV52TTBUS5_DescIdentificador ;
               AV54planilla_excel.get_Cells(AV55FILA, 5, 1, 1).Text = AV53NumeroIdentificador ;
               AV55FILA = (int)(AV55FILA+1) ;
               pr_default.readNext(3);
            }
            pr_default.close(3);
            AV55FILA = (int)(AV55FILA+1) ;
         }
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
         gxfirstwebparm = "" ;
         AV8AHORA = (DateTime)(DateTime.MinValue) ;
         AV17NOMBRE_REPORTE = "" ;
         Gx_time = "" ;
         AV54planilla_excel = new ExcelDocumentI();
         scmdbuf = "" ;
         P001E2_A35TTBUS7_CodResp = new String[] {""} ;
         P001E2_n35TTBUS7_CodResp = new bool[] {false} ;
         P001E2_A37TTBUS_CodPosicion = new short[1] ;
         P001E2_A29TTBUS_Alquilado = new short[1] ;
         P001E2_A12TTBUS_Descripcion = new String[] {""} ;
         P001E2_A23TTBUS_Estado = new short[1] ;
         P001E2_A11TTBUS_Id = new int[1] ;
         A35TTBUS7_CodResp = "" ;
         A12TTBUS_Descripcion = "" ;
         AV50tTTBUS_Descripcion = "" ;
         P001E3_A33TTBUS7_Pos = new short[1] ;
         P001E4_A26TTBUS2_EstadoEnvio = new short[1] ;
         P001E4_A22TTBUS2_IdBien = new int[1] ;
         P001E4_A24TTBUS2_RespDesde = new String[] {""} ;
         P001E4_A25TTBUS2_RespHacia = new String[] {""} ;
         P001E4_A52TTBUS2_IdMovimiento = new long[1] ;
         A24TTBUS2_RespDesde = "" ;
         A25TTBUS2_RespHacia = "" ;
         AV26TTBUS_Descripcion = "" ;
         AV9alquilado = "" ;
         P001E5_A21TTBUS5_DescIdentificador = new String[] {""} ;
         P001E5_n21TTBUS5_DescIdentificador = new bool[] {false} ;
         P001E5_A11TTBUS_Id = new int[1] ;
         P001E5_A15NumeroIdentificador = new String[] {""} ;
         P001E5_A14IdIdentificador = new int[1] ;
         A21TTBUS5_DescIdentificador = "" ;
         A15NumeroIdentificador = "" ;
         AV53NumeroIdentificador = "" ;
         AV52TTBUS5_DescIdentificador = "" ;
         P001E6_A20TTBUS5_IdIdentificador = new int[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.aptbus016_2__default(),
            new Object[][] {
                new Object[] {
               P001E2_A35TTBUS7_CodResp, P001E2_n35TTBUS7_CodResp, P001E2_A37TTBUS_CodPosicion, P001E2_A29TTBUS_Alquilado, P001E2_A12TTBUS_Descripcion, P001E2_A23TTBUS_Estado, P001E2_A11TTBUS_Id
               }
               , new Object[] {
               P001E3_A33TTBUS7_Pos
               }
               , new Object[] {
               P001E4_A26TTBUS2_EstadoEnvio, P001E4_A22TTBUS2_IdBien, P001E4_A24TTBUS2_RespDesde, P001E4_A25TTBUS2_RespHacia, P001E4_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               P001E5_A21TTBUS5_DescIdentificador, P001E5_n21TTBUS5_DescIdentificador, P001E5_A11TTBUS_Id, P001E5_A15NumeroIdentificador, P001E5_A14IdIdentificador
               }
               , new Object[] {
               P001E6_A20TTBUS5_IdIdentificador
               }
            }
         );
         Gx_time = context.localUtil.Time( ) ;
         /* GeneXus formulas. */
         Gx_time = context.localUtil.Time( ) ;
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short AV47TTBUS7_Pos ;
      private short A37TTBUS_CodPosicion ;
      private short A29TTBUS_Alquilado ;
      private short A23TTBUS_Estado ;
      private short AV24TTBUS_CodPosicion ;
      private short AV23TTBUS_Alquilado ;
      private short A33TTBUS7_Pos ;
      private short A26TTBUS2_EstadoEnvio ;
      private short AV10band ;
      private int AV55FILA ;
      private int A11TTBUS_Id ;
      private int AV28TTBUS_Id ;
      private int A22TTBUS2_IdBien ;
      private int AV33TTBUS2_IdBien ;
      private int A14IdIdentificador ;
      private int AV51IdIdentificador ;
      private int A20TTBUS5_IdIdentificador ;
      private long A52TTBUS2_IdMovimiento ;
      private String gxfirstwebparm ;
      private String AV40USUARIO ;
      private String AV46TTBUS7_CodResp ;
      private String AV17NOMBRE_REPORTE ;
      private String Gx_time ;
      private String scmdbuf ;
      private String A35TTBUS7_CodResp ;
      private String A24TTBUS2_RespDesde ;
      private String A25TTBUS2_RespHacia ;
      private String AV9alquilado ;
      private String A21TTBUS5_DescIdentificador ;
      private String AV52TTBUS5_DescIdentificador ;
      private DateTime AV8AHORA ;
      private bool entryPointCalled ;
      private bool n35TTBUS7_CodResp ;
      private bool returnInSub ;
      private bool n21TTBUS5_DescIdentificador ;
      private String A12TTBUS_Descripcion ;
      private String AV50tTTBUS_Descripcion ;
      private String AV26TTBUS_Descripcion ;
      private String A15NumeroIdentificador ;
      private String AV53NumeroIdentificador ;
      private IGxDataStore dsDefault ;
      private String aP0_USUARIO ;
      private short aP1_TTBUS7_Pos ;
      private String aP2_TTBUS7_CodResp ;
      private IDataStoreProvider pr_default ;
      private String[] P001E2_A35TTBUS7_CodResp ;
      private bool[] P001E2_n35TTBUS7_CodResp ;
      private short[] P001E2_A37TTBUS_CodPosicion ;
      private short[] P001E2_A29TTBUS_Alquilado ;
      private String[] P001E2_A12TTBUS_Descripcion ;
      private short[] P001E2_A23TTBUS_Estado ;
      private int[] P001E2_A11TTBUS_Id ;
      private short[] P001E3_A33TTBUS7_Pos ;
      private short[] P001E4_A26TTBUS2_EstadoEnvio ;
      private int[] P001E4_A22TTBUS2_IdBien ;
      private String[] P001E4_A24TTBUS2_RespDesde ;
      private String[] P001E4_A25TTBUS2_RespHacia ;
      private long[] P001E4_A52TTBUS2_IdMovimiento ;
      private String[] P001E5_A21TTBUS5_DescIdentificador ;
      private bool[] P001E5_n21TTBUS5_DescIdentificador ;
      private int[] P001E5_A11TTBUS_Id ;
      private String[] P001E5_A15NumeroIdentificador ;
      private int[] P001E5_A14IdIdentificador ;
      private int[] P001E6_A20TTBUS5_IdIdentificador ;
      private ExcelDocumentI AV54planilla_excel ;
   }

   public class aptbus016_2__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P001E2( short AV47TTBUS7_Pos ,
                                             short A37TTBUS_CodPosicion )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [1] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT T2.[TTBUS7_CodResp], T1.[TTBUS_CodPosicion] AS TTBUS_CodPosicion, T1.[TTBUS_Alquilado], T1.[TTBUS_Descripcion], T1.[TTBUS_Estado], T1.[TTBUS_Id] FROM ([TTBUS000] T1 WITH (NOLOCK) INNER JOIN [TTBUS007] T2 WITH (NOLOCK) ON T2.[TTBUS7_Pos] = T1.[TTBUS_CodPosicion])" ;
         if ( AV47TTBUS7_Pos != 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[TTBUS_CodPosicion] = @AV47TTBUS7_Pos)" ;
            }
            else
            {
               sWhereString = sWhereString + " (T1.[TTBUS_CodPosicion] = @AV47TTBUS7_Pos)" ;
            }
         }
         else
         {
            GXv_int1[0] = 1 ;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[TTBUS_Id]" ;
         GXv_Object2[0] = scmdbuf ;
         GXv_Object2[1] = (Object)(GXv_int1) ;
         return GXv_Object2 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P001E2( (short)dynConstraints[0] , (short)dynConstraints[1] );
         }
         return base.getDynamicStatement(cursor, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001E3 ;
          prmP001E3 = new Object[] {
          new Object[] {"@AV24TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP001E4 ;
          prmP001E4 = new Object[] {
          new Object[] {"@AV28TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001E5 ;
          prmP001E5 = new Object[] {
          new Object[] {"@AV33TTBUS2_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001E6 ;
          prmP001E6 = new Object[] {
          new Object[] {"@AV51IdIdentificador",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001E2 ;
          prmP001E2 = new Object[] {
          new Object[] {"@AV47TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001E2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001E2,100,0,true,false )
             ,new CursorDef("P001E3", "SELECT [TTBUS7_Pos] FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @AV24TTBUS_CodPosicion ORDER BY [TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001E3,1,0,true,true )
             ,new CursorDef("P001E4", "SELECT [TTBUS2_EstadoEnvio], [TTBUS2_IdBien], [TTBUS2_RespDesde], [TTBUS2_RespHacia], [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE ([TTBUS2_IdBien] = @AV28TTBUS_Id) AND ([TTBUS2_EstadoEnvio] = 1) ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001E4,100,0,true,false )
             ,new CursorDef("P001E5", "SELECT T2.[TTBUS5_DescIdentificador], T1.[TTBUS_Id], T1.[NumeroIdentificador], T1.[IdIdentificador] AS IdIdentificador FROM ([TTBUS000Identificadores] T1 WITH (NOLOCK) INNER JOIN [TTBUS005] T2 WITH (NOLOCK) ON T2.[TTBUS5_IdIdentificador] = T1.[IdIdentificador]) WHERE T1.[TTBUS_Id] = @AV33TTBUS2_IdBien ORDER BY T1.[TTBUS_Id], T1.[IdIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001E5,100,0,true,false )
             ,new CursorDef("P001E6", "SELECT [TTBUS5_IdIdentificador] FROM [TTBUS005] WITH (NOLOCK) WHERE [TTBUS5_IdIdentificador] = @AV51IdIdentificador ORDER BY [TTBUS5_IdIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001E6,1,0,false,true )
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((int[]) buf[6])[0] = rslt.getInt(6) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 15) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 60) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((int[]) buf[4])[0] = rslt.getInt(4) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0 ;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (short)parms[1]);
                }
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
