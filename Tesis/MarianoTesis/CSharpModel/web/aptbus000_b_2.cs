/*
               File: PTBUS000_b_2
        Description: Mail de baja de bien de uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:33.87
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
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class aptbus000_b_2 : GXProcedure
   {
      public static int Main( String[] args )
      {
         try
         {
            ArrayList args1 =  new ArrayList();
            foreach( string arg in args) {
                if (arg.StartsWith("\\config:"))
                    GeneXus.Configuration.Config.ConfigFileName = arg.Substring( 8) ;
                else
                    args1.Add( arg);
            }
            args = (string[])(args1.ToArray( typeof(string)));
            String aP0_cTTBUS_Id = new String(' ',0)  ;
             long aP1_PRC_NRO ;
            if ( 0 < args.Length )
            {
               aP0_cTTBUS_Id=((String)(args[0]));
            }
            else
            {
               aP0_cTTBUS_Id="";
            }
            if ( 1 < args.Length )
            {
               aP1_PRC_NRO=((long)(NumberUtil.Val( (String)(args[1]), ".")));
            }
            else
            {
               aP1_PRC_NRO=0;
            }
            new aptbus000_b_2().execute(ref aP0_cTTBUS_Id, ref aP1_PRC_NRO);
            return 0 ;
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            Console.WriteLine( e .ToString());
            return 1 ;
         }
      }

      public void executeCmdLine( String[] args )
      {
         String aP0_cTTBUS_Id = new String(' ',0)  ;
          long aP1_PRC_NRO ;
         if ( 0 < args.Length )
         {
            aP0_cTTBUS_Id=((String)(args[0]));
         }
         else
         {
            aP0_cTTBUS_Id="";
         }
         if ( 1 < args.Length )
         {
            aP1_PRC_NRO=((long)(NumberUtil.Val( (String)(args[1]), ".")));
         }
         else
         {
            aP1_PRC_NRO=0;
         }
         execute(ref aP0_cTTBUS_Id, ref aP1_PRC_NRO);
      }

      public aptbus000_b_2( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public aptbus000_b_2( IGxContext context )
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

      public void execute( ref String aP0_cTTBUS_Id ,
                           ref long aP1_PRC_NRO )
      {
         this.AV37cTTBUS_Id = aP0_cTTBUS_Id;
         this.AV8PRC_NRO = aP1_PRC_NRO;
         initialize();
         executePrivate();
         aP0_cTTBUS_Id=this.AV37cTTBUS_Id;
         aP1_PRC_NRO=this.AV8PRC_NRO;
      }

      public long executeUdp( ref String aP0_cTTBUS_Id )
      {
         this.AV37cTTBUS_Id = aP0_cTTBUS_Id;
         this.AV8PRC_NRO = aP1_PRC_NRO;
         initialize();
         executePrivate();
         aP0_cTTBUS_Id=this.AV37cTTBUS_Id;
         aP1_PRC_NRO=this.AV8PRC_NRO;
         return AV8PRC_NRO ;
      }

      public void executeSubmit( ref String aP0_cTTBUS_Id ,
                                 ref long aP1_PRC_NRO )
      {
         aptbus000_b_2 objaptbus000_b_2;
         objaptbus000_b_2 = new aptbus000_b_2();
         objaptbus000_b_2.AV37cTTBUS_Id = aP0_cTTBUS_Id;
         objaptbus000_b_2.AV8PRC_NRO = aP1_PRC_NRO;
         objaptbus000_b_2.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objaptbus000_b_2.executePrivateCatch ));
         aP0_cTTBUS_Id=this.AV37cTTBUS_Id;
         aP1_PRC_NRO=this.AV8PRC_NRO;
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
            Console.WriteLine( e .ToString());
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         AV23AHORA = DateTimeUtil.Now( ) ;
         AV22PRC_MSG = "PROCESO INICIADO..." ;
         GXt_int1 = 1 ;
         GXt_dtime2 = AV23AHORA ;
         GXt_char3 = " " ;
         new pcol001(context ).execute( ref  AV8PRC_NRO, ref  GXt_int1, ref  GXt_dtime2, ref  GXt_char3, ref  AV22PRC_MSG) ;
         AV23AHORA = GXt_dtime2 ;
         AV27TTBUS_Id = (int)(NumberUtil.Val( AV37cTTBUS_Id, ".")) ;
         /* Using cursor P001J2 */
         pr_default.execute(0, new Object[] {AV27TTBUS_Id});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A11TTBUS_Id = P001J2_A11TTBUS_Id[0] ;
            A12TTBUS_Descripcion = P001J2_A12TTBUS_Descripcion[0] ;
            A37TTBUS_CodPosicion = P001J2_A37TTBUS_CodPosicion[0] ;
            A38TTBUS_DesPosicion = P001J2_A38TTBUS_DesPosicion[0] ;
            A43TTBUS_MotivoBaja = P001J2_A43TTBUS_MotivoBaja[0] ;
            n43TTBUS_MotivoBaja = P001J2_n43TTBUS_MotivoBaja[0] ;
            A195TTBUS_UsuarioBaja = P001J2_A195TTBUS_UsuarioBaja[0] ;
            n195TTBUS_UsuarioBaja = P001J2_n195TTBUS_UsuarioBaja[0] ;
            AV26TTBUS_Descripcion = A12TTBUS_Descripcion ;
            AV39TTBUS_CodPosicion = A37TTBUS_CodPosicion ;
            AV38TTBUS_DesPosicion = A38TTBUS_DesPosicion ;
            AV43TTBUS_MotivoBaja = A43TTBUS_MotivoBaja ;
            AV44TTBUS_UsuarioBaja = A195TTBUS_UsuarioBaja ;
            /* Using cursor P001J3 */
            pr_default.execute(1, new Object[] {AV44TTBUS_UsuarioBaja});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A6USU_COD = P001J3_A6USU_COD[0] ;
               A7USU_DES = P001J3_A7USU_DES[0] ;
               AV45USU_DES = StringUtil.Trim( A7USU_DES) ;
               new ptbus038(context ).execute(  AV44TTBUS_UsuarioBaja, out  AV46PER_MAIL) ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
            /* Using cursor P001J4 */
            pr_default.execute(2, new Object[] {AV39TTBUS_CodPosicion});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A33TTBUS7_Pos = P001J4_A33TTBUS7_Pos[0] ;
               A35TTBUS7_CodResp = P001J4_A35TTBUS7_CodResp[0] ;
               A36TTBUS7_DesResp = P001J4_A36TTBUS7_DesResp[0] ;
               n36TTBUS7_DesResp = P001J4_n36TTBUS7_DesResp[0] ;
               A36TTBUS7_DesResp = P001J4_A36TTBUS7_DesResp[0] ;
               n36TTBUS7_DesResp = P001J4_n36TTBUS7_DesResp[0] ;
               AV40TTBUS7_CodResp = StringUtil.Trim( A35TTBUS7_CodResp) ;
               AV41TTBUS7_DesResp = StringUtil.Trim( A36TTBUS7_DesResp) ;
               new ptbus038(context ).execute(  AV40TTBUS7_CodResp, out  AV11dPER_MAIL) ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(2);
            /* Using cursor P001J5 */
            pr_default.execute(3);
            while ( (pr_default.getStatus(3) != 101) )
            {
               A33TTBUS7_Pos = P001J5_A33TTBUS7_Pos[0] ;
               A35TTBUS7_CodResp = P001J5_A35TTBUS7_CodResp[0] ;
               A36TTBUS7_DesResp = P001J5_A36TTBUS7_DesResp[0] ;
               n36TTBUS7_DesResp = P001J5_n36TTBUS7_DesResp[0] ;
               A36TTBUS7_DesResp = P001J5_A36TTBUS7_DesResp[0] ;
               n36TTBUS7_DesResp = P001J5_n36TTBUS7_DesResp[0] ;
               AV42hTTBUS7_CodResp = StringUtil.Trim( A35TTBUS7_CodResp) ;
               AV13hUSU_DES = StringUtil.Trim( A36TTBUS7_DesResp) ;
               new ptbus038(context ).execute(  AV42hTTBUS7_CodResp, out  AV14hPER_MAIL) ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(3);
            AV25link_sistema = "http://intranetamsx/HTBUS001B.aspx" ;
            AV16ASUNTO = "BAJA DEL BIEN DE USO " + "\"" + StringUtil.Trim( StringUtil.Upper( AV26TTBUS_Descripcion)) + "\"" ;
            AV15MENSAJE = "El bien de uso Nº" + StringUtil.Trim( StringUtil.Str( (decimal)(AV27TTBUS_Id), 8, 0)) + ": \"" + StringUtil.Trim( AV26TTBUS_Descripcion) + "\"" + " ha sido dado de baja por el usuario " + StringUtil.Trim( AV45USU_DES) + " (correo: " + StringUtil.Trim( AV46PER_MAIL) + ")." + StringUtil.Chr( 13) ;
            AV15MENSAJE = AV15MENSAJE + "La última posición del bien es " + StringUtil.Trim( AV38TTBUS_DesPosicion) + ", y el responsable es " + StringUtil.Trim( AV41TTBUS7_DesResp) + " (correo: " + StringUtil.Trim( AV11dPER_MAIL) + ")." + StringUtil.Chr( 13) ;
            AV15MENSAJE = AV15MENSAJE + "El motivo de baja es: " + StringUtil.Trim( AV43TTBUS_MotivoBaja) + "." + StringUtil.Chr( 13) ;
            AV15MENSAJE = StringUtil.Trim( AV15MENSAJE) + "Los identificadores del bien son los siguientes: " + StringUtil.Chr( 13) ;
            /* Execute user subroutine: S1190 */
            S1190 ();
            if ( returnInSub )
            {
               pr_default.close(0);
               this.cleanup();
               if (true) return;
            }
            AV15MENSAJE = AV15MENSAJE + StringUtil.Chr( 13) ;
            AV15MENSAJE = StringUtil.Trim( AV15MENSAJE) + "Para ver más detalles haga click en el siguiente hipervínculo: " ;
            AV15MENSAJE = StringUtil.Trim( AV15MENSAJE) + " " + StringUtil.Trim( AV25link_sistema) ;
            AV22PRC_MSG = "ENVIANDO MAIL BAJA BIEN DE USO" ;
            GXt_int1 = 1 ;
            GXt_dtime2 = AV23AHORA ;
            GXt_char3 = " " ;
            new pcol001(context ).execute( ref  AV8PRC_NRO, ref  GXt_int1, ref  GXt_dtime2, ref  GXt_char3, ref  AV22PRC_MSG) ;
            AV23AHORA = GXt_dtime2 ;
            GXt_char4 = "Intranet" ;
            GXt_char5 = "intranet@sancorsalud.com.ar" ;
            GXt_char6 = "intra860" ;
            GXt_char7 = "" ;
            GXt_char8 = "" ;
            new pmail_html_b(context ).execute( ref  GXt_char4, ref  GXt_char5, ref  GXt_char6, ref  AV13hUSU_DES, ref  AV14hPER_MAIL, ref  GXt_char7, ref  AV16ASUNTO, ref  AV15MENSAJE, ref  AV20WebrWapp, ref  AV17SDTAttachs, ref  GXt_char8) ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         AV24PRC_SAL = StringUtil.Trim( AV18NOMBRE_REPORTE) ;
         AV23AHORA = DateTimeUtil.Now( ) ;
         AV22PRC_MSG = "PROCESO FINALIZADO CORRECTAMENTE." ;
         /* Optimized UPDATE. */
         /* Using cursor P001J6 */
         pr_default.execute(4, new Object[] {AV24PRC_SAL, AV22PRC_MSG, AV23AHORA, AV8PRC_NRO});
         pr_default.close(4);
         /* End optimized UPDATE. */
         this.cleanup();
      }

      protected void S1190( )
      {
         /* 'IDENTIFICADORES' Routine */
         /* Using cursor P001J7 */
         pr_default.execute(5, new Object[] {AV27TTBUS_Id});
         while ( (pr_default.getStatus(5) != 101) )
         {
            A14IdIdentificador = P001J7_A14IdIdentificador[0] ;
            A11TTBUS_Id = P001J7_A11TTBUS_Id[0] ;
            A15NumeroIdentificador = P001J7_A15NumeroIdentificador[0] ;
            AV32NumeroIdentificador = StringUtil.Trim( A15NumeroIdentificador) ;
            /* Using cursor P001J8 */
            pr_default.execute(6, new Object[] {A14IdIdentificador});
            while ( (pr_default.getStatus(6) != 101) )
            {
               A20TTBUS5_IdIdentificador = P001J8_A20TTBUS5_IdIdentificador[0] ;
               A21TTBUS5_DescIdentificador = P001J8_A21TTBUS5_DescIdentificador[0] ;
               AV15MENSAJE = StringUtil.Trim( AV15MENSAJE) + " -  " + StringUtil.Trim( A21TTBUS5_DescIdentificador) + ": " + StringUtil.Trim( AV32NumeroIdentificador) + StringUtil.Chr( 13) ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(6);
            pr_default.readNext(5);
         }
         pr_default.close(5);
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PTBUS000_b_2");
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
         AV23AHORA = (DateTime)(DateTime.MinValue) ;
         AV22PRC_MSG = "" ;
         scmdbuf = "" ;
         P001J2_A11TTBUS_Id = new int[1] ;
         P001J2_A12TTBUS_Descripcion = new String[] {""} ;
         P001J2_A37TTBUS_CodPosicion = new short[1] ;
         P001J2_A38TTBUS_DesPosicion = new String[] {""} ;
         P001J2_A43TTBUS_MotivoBaja = new String[] {""} ;
         P001J2_n43TTBUS_MotivoBaja = new bool[] {false} ;
         P001J2_A195TTBUS_UsuarioBaja = new String[] {""} ;
         P001J2_n195TTBUS_UsuarioBaja = new bool[] {false} ;
         A12TTBUS_Descripcion = "" ;
         A38TTBUS_DesPosicion = "" ;
         A43TTBUS_MotivoBaja = "" ;
         A195TTBUS_UsuarioBaja = "" ;
         AV26TTBUS_Descripcion = "" ;
         AV38TTBUS_DesPosicion = "" ;
         AV43TTBUS_MotivoBaja = "" ;
         AV44TTBUS_UsuarioBaja = "" ;
         P001J3_A6USU_COD = new String[] {""} ;
         P001J3_A7USU_DES = new String[] {""} ;
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         AV45USU_DES = "" ;
         AV46PER_MAIL = "" ;
         P001J4_A33TTBUS7_Pos = new short[1] ;
         P001J4_A35TTBUS7_CodResp = new String[] {""} ;
         P001J4_A36TTBUS7_DesResp = new String[] {""} ;
         P001J4_n36TTBUS7_DesResp = new bool[] {false} ;
         A35TTBUS7_CodResp = "" ;
         A36TTBUS7_DesResp = "" ;
         AV40TTBUS7_CodResp = "" ;
         AV41TTBUS7_DesResp = "" ;
         AV11dPER_MAIL = "" ;
         P001J5_A33TTBUS7_Pos = new short[1] ;
         P001J5_A35TTBUS7_CodResp = new String[] {""} ;
         P001J5_A36TTBUS7_DesResp = new String[] {""} ;
         P001J5_n36TTBUS7_DesResp = new bool[] {false} ;
         AV42hTTBUS7_CodResp = "" ;
         AV13hUSU_DES = "" ;
         AV14hPER_MAIL = "" ;
         AV25link_sistema = "" ;
         AV16ASUNTO = "" ;
         AV15MENSAJE = "" ;
         GXt_dtime2 = (DateTime)(DateTime.MinValue) ;
         GXt_char3 = "" ;
         GXt_char4 = "" ;
         GXt_char5 = "" ;
         GXt_char6 = "" ;
         GXt_char7 = "" ;
         AV20WebrWapp = new GxWebWrapper();
         AV17SDTAttachs = new GxObjectCollection( context, "SDTAttachs.SDTAttachsItem", "MarianoTesis", "SdtSDTAttachs_SDTAttachsItem", "GeneXus.Programs");
         GXt_char8 = "" ;
         AV24PRC_SAL = "" ;
         AV18NOMBRE_REPORTE = "" ;
         A159PRC_SAL = "" ;
         A161PRC_MSG = "" ;
         A157PRC_FIN = (DateTime)(DateTime.MinValue) ;
         P001J7_A14IdIdentificador = new int[1] ;
         P001J7_A11TTBUS_Id = new int[1] ;
         P001J7_A15NumeroIdentificador = new String[] {""} ;
         A15NumeroIdentificador = "" ;
         AV32NumeroIdentificador = "" ;
         P001J8_A20TTBUS5_IdIdentificador = new int[1] ;
         P001J8_A21TTBUS5_DescIdentificador = new String[] {""} ;
         A21TTBUS5_DescIdentificador = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.aptbus000_b_2__default(),
            new Object[][] {
                new Object[] {
               P001J2_A11TTBUS_Id, P001J2_A12TTBUS_Descripcion, P001J2_A37TTBUS_CodPosicion, P001J2_A38TTBUS_DesPosicion, P001J2_A43TTBUS_MotivoBaja, P001J2_n43TTBUS_MotivoBaja, P001J2_A195TTBUS_UsuarioBaja, P001J2_n195TTBUS_UsuarioBaja
               }
               , new Object[] {
               P001J3_A6USU_COD, P001J3_A7USU_DES
               }
               , new Object[] {
               P001J4_A33TTBUS7_Pos, P001J4_A35TTBUS7_CodResp, P001J4_A36TTBUS7_DesResp, P001J4_n36TTBUS7_DesResp
               }
               , new Object[] {
               P001J5_A33TTBUS7_Pos, P001J5_A35TTBUS7_CodResp, P001J5_A36TTBUS7_DesResp, P001J5_n36TTBUS7_DesResp
               }
               , new Object[] {
               }
               , new Object[] {
               P001J7_A14IdIdentificador, P001J7_A11TTBUS_Id, P001J7_A15NumeroIdentificador
               }
               , new Object[] {
               P001J8_A20TTBUS5_IdIdentificador, P001J8_A21TTBUS5_DescIdentificador
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A37TTBUS_CodPosicion ;
      private short AV39TTBUS_CodPosicion ;
      private short A33TTBUS7_Pos ;
      private short GXt_int1 ;
      private int AV27TTBUS_Id ;
      private int A11TTBUS_Id ;
      private int A14IdIdentificador ;
      private int A20TTBUS5_IdIdentificador ;
      private long AV8PRC_NRO ;
      private String AV37cTTBUS_Id ;
      private String AV22PRC_MSG ;
      private String scmdbuf ;
      private String A38TTBUS_DesPosicion ;
      private String A195TTBUS_UsuarioBaja ;
      private String AV38TTBUS_DesPosicion ;
      private String AV44TTBUS_UsuarioBaja ;
      private String A6USU_COD ;
      private String A7USU_DES ;
      private String AV45USU_DES ;
      private String AV46PER_MAIL ;
      private String A35TTBUS7_CodResp ;
      private String A36TTBUS7_DesResp ;
      private String AV40TTBUS7_CodResp ;
      private String AV41TTBUS7_DesResp ;
      private String AV11dPER_MAIL ;
      private String AV42hTTBUS7_CodResp ;
      private String AV13hUSU_DES ;
      private String AV14hPER_MAIL ;
      private String AV25link_sistema ;
      private String AV16ASUNTO ;
      private String GXt_char3 ;
      private String GXt_char4 ;
      private String GXt_char5 ;
      private String GXt_char6 ;
      private String GXt_char7 ;
      private String GXt_char8 ;
      private String AV24PRC_SAL ;
      private String AV18NOMBRE_REPORTE ;
      private String A159PRC_SAL ;
      private String A161PRC_MSG ;
      private String A21TTBUS5_DescIdentificador ;
      private DateTime AV23AHORA ;
      private DateTime GXt_dtime2 ;
      private DateTime A157PRC_FIN ;
      private bool n43TTBUS_MotivoBaja ;
      private bool n195TTBUS_UsuarioBaja ;
      private bool n36TTBUS7_DesResp ;
      private bool returnInSub ;
      private String AV15MENSAJE ;
      private String A12TTBUS_Descripcion ;
      private String A43TTBUS_MotivoBaja ;
      private String AV26TTBUS_Descripcion ;
      private String AV43TTBUS_MotivoBaja ;
      private String A15NumeroIdentificador ;
      private String AV32NumeroIdentificador ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_cTTBUS_Id ;
      private long aP1_PRC_NRO ;
      private IDataStoreProvider pr_default ;
      private int[] P001J2_A11TTBUS_Id ;
      private String[] P001J2_A12TTBUS_Descripcion ;
      private short[] P001J2_A37TTBUS_CodPosicion ;
      private String[] P001J2_A38TTBUS_DesPosicion ;
      private String[] P001J2_A43TTBUS_MotivoBaja ;
      private bool[] P001J2_n43TTBUS_MotivoBaja ;
      private String[] P001J2_A195TTBUS_UsuarioBaja ;
      private bool[] P001J2_n195TTBUS_UsuarioBaja ;
      private String[] P001J3_A6USU_COD ;
      private String[] P001J3_A7USU_DES ;
      private short[] P001J4_A33TTBUS7_Pos ;
      private String[] P001J4_A35TTBUS7_CodResp ;
      private String[] P001J4_A36TTBUS7_DesResp ;
      private bool[] P001J4_n36TTBUS7_DesResp ;
      private short[] P001J5_A33TTBUS7_Pos ;
      private String[] P001J5_A35TTBUS7_CodResp ;
      private String[] P001J5_A36TTBUS7_DesResp ;
      private bool[] P001J5_n36TTBUS7_DesResp ;
      private int[] P001J7_A14IdIdentificador ;
      private int[] P001J7_A11TTBUS_Id ;
      private String[] P001J7_A15NumeroIdentificador ;
      private int[] P001J8_A20TTBUS5_IdIdentificador ;
      private String[] P001J8_A21TTBUS5_DescIdentificador ;
      private GxWebWrapper AV20WebrWapp ;
      [ObjectCollection(ItemType=typeof( SdtSDTAttachs_SDTAttachsItem ))]
      private IGxCollection AV17SDTAttachs ;
   }

   public class aptbus000_b_2__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new UpdateCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001J2 ;
          prmP001J2 = new Object[] {
          new Object[] {"@AV27TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001J3 ;
          prmP001J3 = new Object[] {
          new Object[] {"@AV44TTBUS_UsuarioBaja",SqlDbType.Char,15,0}
          } ;
          Object[] prmP001J4 ;
          prmP001J4 = new Object[] {
          new Object[] {"@AV39TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP001J5 ;
          prmP001J5 = new Object[] {
          } ;
          Object[] prmP001J6 ;
          prmP001J6 = new Object[] {
          new Object[] {"@PRC_SAL",SqlDbType.Char,100,0} ,
          new Object[] {"@PRC_MSG",SqlDbType.Char,75,0} ,
          new Object[] {"@PRC_FIN",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AV8PRC_NRO",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmP001J7 ;
          prmP001J7 = new Object[] {
          new Object[] {"@AV27TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001J8 ;
          prmP001J8 = new Object[] {
          new Object[] {"@IdIdentificador",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001J2", "SELECT [TTBUS_Id], [TTBUS_Descripcion], [TTBUS_CodPosicion], [TTBUS_DesPosicion], [TTBUS_MotivoBaja], [TTBUS_UsuarioBaja] FROM [TTBUS000] WITH (NOLOCK) WHERE [TTBUS_Id] = @AV27TTBUS_Id ORDER BY [TTBUS_Id] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001J2,1,0,true,true )
             ,new CursorDef("P001J3", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @AV44TTBUS_UsuarioBaja ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001J3,1,0,true,true )
             ,new CursorDef("P001J4", "SELECT T1.[TTBUS7_Pos], T1.[TTBUS7_CodResp] AS TTBUS7_CodResp, T2.[USU_DES] AS TTBUS7_DesResp FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[TTBUS7_CodResp]) WHERE T1.[TTBUS7_Pos] = @AV39TTBUS_CodPosicion ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001J4,1,0,true,true )
             ,new CursorDef("P001J5", "SELECT T1.[TTBUS7_Pos], T1.[TTBUS7_CodResp] AS TTBUS7_CodResp, T2.[USU_DES] AS TTBUS7_DesResp FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[TTBUS7_CodResp]) WHERE T1.[TTBUS7_Pos] = 998 ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001J5,1,0,true,true )
             ,new CursorDef("P001J6", "UPDATE [COL000] SET [PRC_EST]=2, [PRC_SAL]=@PRC_SAL, [PRC_MSG]=@PRC_MSG, [PRC_FIN]=@PRC_FIN  WHERE [PRC_NRO] = @AV8PRC_NRO", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001J6)
             ,new CursorDef("P001J7", "SELECT [IdIdentificador], [TTBUS_Id], [NumeroIdentificador] FROM [TTBUS000Identificadores] WITH (NOLOCK) WHERE [TTBUS_Id] = @AV27TTBUS_Id ORDER BY [TTBUS_Id], [IdIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001J7,100,0,true,false )
             ,new CursorDef("P001J8", "SELECT [TTBUS5_IdIdentificador], [TTBUS5_DescIdentificador] FROM [TTBUS005] WITH (NOLOCK) WHERE [TTBUS5_IdIdentificador] = @IdIdentificador ORDER BY [TTBUS5_IdIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001J8,1,0,false,true )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((String[]) buf[6])[0] = rslt.getString(6, 15) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                break;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 6 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 60) ;
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
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (long)parms[3]);
                break;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
