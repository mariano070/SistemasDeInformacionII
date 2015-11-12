/*
               File: PTBUS030
        Description: Asigna bienes desde contabilidad a trazabilidad
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:7:46.65
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
   public class ptbus030 : GXProcedure
   {
      public ptbus030( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus030( IGxContext context )
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

      public void execute( ref String aP0_BUS_EMP ,
                           ref short aP1_BUS_RUB ,
                           ref short aP2_BUS_COD ,
                           ref short aP3_BUS_PAR ,
                           ref int aP4_BUS_IDT ,
                           ref int aP5_BUS_IDTa ,
                           ref String aP6_USUARIO )
      {
         this.AV8BUS_EMP = aP0_BUS_EMP;
         this.AV9BUS_RUB = aP1_BUS_RUB;
         this.AV10BUS_COD = aP2_BUS_COD;
         this.AV11BUS_PAR = aP3_BUS_PAR;
         this.AV12BUS_IDT = aP4_BUS_IDT;
         this.AV14BUS_IDTa = aP5_BUS_IDTa;
         this.AV15USUARIO = aP6_USUARIO;
         initialize();
         executePrivate();
         aP0_BUS_EMP=this.AV8BUS_EMP;
         aP1_BUS_RUB=this.AV9BUS_RUB;
         aP2_BUS_COD=this.AV10BUS_COD;
         aP3_BUS_PAR=this.AV11BUS_PAR;
         aP4_BUS_IDT=this.AV12BUS_IDT;
         aP5_BUS_IDTa=this.AV14BUS_IDTa;
         aP6_USUARIO=this.AV15USUARIO;
      }

      public String executeUdp( ref String aP0_BUS_EMP ,
                                ref short aP1_BUS_RUB ,
                                ref short aP2_BUS_COD ,
                                ref short aP3_BUS_PAR ,
                                ref int aP4_BUS_IDT ,
                                ref int aP5_BUS_IDTa )
      {
         this.AV8BUS_EMP = aP0_BUS_EMP;
         this.AV9BUS_RUB = aP1_BUS_RUB;
         this.AV10BUS_COD = aP2_BUS_COD;
         this.AV11BUS_PAR = aP3_BUS_PAR;
         this.AV12BUS_IDT = aP4_BUS_IDT;
         this.AV14BUS_IDTa = aP5_BUS_IDTa;
         this.AV15USUARIO = aP6_USUARIO;
         initialize();
         executePrivate();
         aP0_BUS_EMP=this.AV8BUS_EMP;
         aP1_BUS_RUB=this.AV9BUS_RUB;
         aP2_BUS_COD=this.AV10BUS_COD;
         aP3_BUS_PAR=this.AV11BUS_PAR;
         aP4_BUS_IDT=this.AV12BUS_IDT;
         aP5_BUS_IDTa=this.AV14BUS_IDTa;
         aP6_USUARIO=this.AV15USUARIO;
         return AV15USUARIO ;
      }

      public void executeSubmit( ref String aP0_BUS_EMP ,
                                 ref short aP1_BUS_RUB ,
                                 ref short aP2_BUS_COD ,
                                 ref short aP3_BUS_PAR ,
                                 ref int aP4_BUS_IDT ,
                                 ref int aP5_BUS_IDTa ,
                                 ref String aP6_USUARIO )
      {
         ptbus030 objptbus030;
         objptbus030 = new ptbus030();
         objptbus030.AV8BUS_EMP = aP0_BUS_EMP;
         objptbus030.AV9BUS_RUB = aP1_BUS_RUB;
         objptbus030.AV10BUS_COD = aP2_BUS_COD;
         objptbus030.AV11BUS_PAR = aP3_BUS_PAR;
         objptbus030.AV12BUS_IDT = aP4_BUS_IDT;
         objptbus030.AV14BUS_IDTa = aP5_BUS_IDTa;
         objptbus030.AV15USUARIO = aP6_USUARIO;
         objptbus030.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus030.executePrivateCatch ));
         aP0_BUS_EMP=this.AV8BUS_EMP;
         aP1_BUS_RUB=this.AV9BUS_RUB;
         aP2_BUS_COD=this.AV10BUS_COD;
         aP3_BUS_PAR=this.AV11BUS_PAR;
         aP4_BUS_IDT=this.AV12BUS_IDT;
         aP5_BUS_IDTa=this.AV14BUS_IDTa;
         aP6_USUARIO=this.AV15USUARIO;
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
         AV16TTBUS3_Sist = 2 ;
         if ( AV12BUS_IDT == 0 )
         {
            /* Using cursor P001R2 */
            pr_default.execute(0, new Object[] {AV14BUS_IDTa});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A11TTBUS_Id = P001R2_A11TTBUS_Id[0] ;
               A8BUS_EMP = P001R2_A8BUS_EMP[0] ;
               n8BUS_EMP = P001R2_n8BUS_EMP[0] ;
               A1BUS_RUB = P001R2_A1BUS_RUB[0] ;
               n1BUS_RUB = P001R2_n1BUS_RUB[0] ;
               A3BUS_COD = P001R2_A3BUS_COD[0] ;
               n3BUS_COD = P001R2_n3BUS_COD[0] ;
               A4BUS_PAR = P001R2_A4BUS_PAR[0] ;
               n4BUS_PAR = P001R2_n4BUS_PAR[0] ;
               A8BUS_EMP = "" ;
               n8BUS_EMP = false ;
               A1BUS_RUB = 0 ;
               n1BUS_RUB = false ;
               A3BUS_COD = 0 ;
               n3BUS_COD = false ;
               A4BUS_PAR = 0 ;
               n4BUS_PAR = false ;
               AV23TTBUS3_IdBien = AV14BUS_IDTa ;
               /* Execute user subroutine: S1173 */
               S1173 ();
               if ( returnInSub )
               {
                  pr_default.close(0);
                  this.cleanup();
                  if (true) return;
               }
               AV18TTBUS3_BusEmp = "" ;
               AV19TTBUS3_BusRub = 0 ;
               AV20TTBUS3_BusCod = 0 ;
               AV21TTBUS3_BusPar = 0 ;
               /* Execute user subroutine: S1286 */
               S1286 ();
               if ( returnInSub )
               {
                  pr_default.close(0);
                  this.cleanup();
                  if (true) return;
               }
               /* Using cursor P001R3 */
               pr_default.execute(1, new Object[] {n8BUS_EMP, A8BUS_EMP, n1BUS_RUB, A1BUS_RUB, n3BUS_COD, A3BUS_COD, n4BUS_PAR, A4BUS_PAR, A11TTBUS_Id});
               pr_default.close(1);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
         }
         else
         {
            /* Using cursor P001R4 */
            pr_default.execute(2, new Object[] {AV14BUS_IDTa});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A11TTBUS_Id = P001R4_A11TTBUS_Id[0] ;
               A8BUS_EMP = P001R4_A8BUS_EMP[0] ;
               n8BUS_EMP = P001R4_n8BUS_EMP[0] ;
               A1BUS_RUB = P001R4_A1BUS_RUB[0] ;
               n1BUS_RUB = P001R4_n1BUS_RUB[0] ;
               A3BUS_COD = P001R4_A3BUS_COD[0] ;
               n3BUS_COD = P001R4_n3BUS_COD[0] ;
               A4BUS_PAR = P001R4_A4BUS_PAR[0] ;
               n4BUS_PAR = P001R4_n4BUS_PAR[0] ;
               A8BUS_EMP = "" ;
               n8BUS_EMP = false ;
               A1BUS_RUB = 0 ;
               n1BUS_RUB = false ;
               A3BUS_COD = 0 ;
               n3BUS_COD = false ;
               A4BUS_PAR = 0 ;
               n4BUS_PAR = false ;
               AV23TTBUS3_IdBien = AV14BUS_IDTa ;
               /* Execute user subroutine: S1173 */
               S1173 ();
               if ( returnInSub )
               {
                  pr_default.close(2);
                  this.cleanup();
                  if (true) return;
               }
               AV18TTBUS3_BusEmp = "" ;
               AV19TTBUS3_BusRub = 0 ;
               AV20TTBUS3_BusCod = 0 ;
               AV21TTBUS3_BusPar = 0 ;
               /* Execute user subroutine: S1286 */
               S1286 ();
               if ( returnInSub )
               {
                  pr_default.close(2);
                  this.cleanup();
                  if (true) return;
               }
               /* Using cursor P001R5 */
               pr_default.execute(3, new Object[] {n8BUS_EMP, A8BUS_EMP, n1BUS_RUB, A1BUS_RUB, n3BUS_COD, A3BUS_COD, n4BUS_PAR, A4BUS_PAR, A11TTBUS_Id});
               pr_default.close(3);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(2);
            /* Using cursor P001R6 */
            pr_default.execute(4, new Object[] {AV8BUS_EMP, AV9BUS_RUB, AV10BUS_COD, AV11BUS_PAR});
            while ( (pr_default.getStatus(4) != 101) )
            {
               A4BUS_PAR = P001R6_A4BUS_PAR[0] ;
               n4BUS_PAR = P001R6_n4BUS_PAR[0] ;
               A3BUS_COD = P001R6_A3BUS_COD[0] ;
               n3BUS_COD = P001R6_n3BUS_COD[0] ;
               A1BUS_RUB = P001R6_A1BUS_RUB[0] ;
               n1BUS_RUB = P001R6_n1BUS_RUB[0] ;
               A8BUS_EMP = P001R6_A8BUS_EMP[0] ;
               n8BUS_EMP = P001R6_n8BUS_EMP[0] ;
               A54BUS_DES = P001R6_A54BUS_DES[0] ;
               AV13BUS_DES = A54BUS_DES ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(4);
            /* Using cursor P001R7 */
            pr_default.execute(5, new Object[] {AV12BUS_IDT});
            while ( (pr_default.getStatus(5) != 101) )
            {
               A11TTBUS_Id = P001R7_A11TTBUS_Id[0] ;
               A8BUS_EMP = P001R7_A8BUS_EMP[0] ;
               n8BUS_EMP = P001R7_n8BUS_EMP[0] ;
               A1BUS_RUB = P001R7_A1BUS_RUB[0] ;
               n1BUS_RUB = P001R7_n1BUS_RUB[0] ;
               A3BUS_COD = P001R7_A3BUS_COD[0] ;
               n3BUS_COD = P001R7_n3BUS_COD[0] ;
               A4BUS_PAR = P001R7_A4BUS_PAR[0] ;
               n4BUS_PAR = P001R7_n4BUS_PAR[0] ;
               A12TTBUS_Descripcion = P001R7_A12TTBUS_Descripcion[0] ;
               A8BUS_EMP = AV8BUS_EMP ;
               n8BUS_EMP = false ;
               A1BUS_RUB = AV9BUS_RUB ;
               n1BUS_RUB = false ;
               A3BUS_COD = AV10BUS_COD ;
               n3BUS_COD = false ;
               A4BUS_PAR = AV11BUS_PAR ;
               n4BUS_PAR = false ;
               A12TTBUS_Descripcion = AV13BUS_DES ;
               AV23TTBUS3_IdBien = AV12BUS_IDT ;
               /* Execute user subroutine: S1173 */
               S1173 ();
               if ( returnInSub )
               {
                  pr_default.close(5);
                  this.cleanup();
                  if (true) return;
               }
               AV18TTBUS3_BusEmp = A8BUS_EMP ;
               AV19TTBUS3_BusRub = A1BUS_RUB ;
               AV20TTBUS3_BusCod = A3BUS_COD ;
               AV21TTBUS3_BusPar = A4BUS_PAR ;
               /* Execute user subroutine: S1286 */
               S1286 ();
               if ( returnInSub )
               {
                  pr_default.close(5);
                  this.cleanup();
                  if (true) return;
               }
               /* Using cursor P001R8 */
               pr_default.execute(6, new Object[] {n8BUS_EMP, A8BUS_EMP, n1BUS_RUB, A1BUS_RUB, n3BUS_COD, A3BUS_COD, n4BUS_PAR, A4BUS_PAR, A12TTBUS_Descripcion, A11TTBUS_Id});
               pr_default.close(6);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(5);
         }
         this.cleanup();
      }

      protected void S1173( )
      {
         /* 'BUSCAR ESTADO PREVIO A CAMBIOS' Routine */
         /* Using cursor P001R9 */
         pr_default.execute(7, new Object[] {AV23TTBUS3_IdBien});
         while ( (pr_default.getStatus(7) != 101) )
         {
            A105TTBUS3_IdBien = P001R9_A105TTBUS3_IdBien[0] ;
            A108TTBUS3_HdwId = P001R9_A108TTBUS3_HdwId[0] ;
            n108TTBUS3_HdwId = P001R9_n108TTBUS3_HdwId[0] ;
            A109TTBUS3_BusEmp = P001R9_A109TTBUS3_BusEmp[0] ;
            n109TTBUS3_BusEmp = P001R9_n109TTBUS3_BusEmp[0] ;
            A110TTBUS3_BusRub = P001R9_A110TTBUS3_BusRub[0] ;
            n110TTBUS3_BusRub = P001R9_n110TTBUS3_BusRub[0] ;
            A111TTBUS3_BusCod = P001R9_A111TTBUS3_BusCod[0] ;
            n111TTBUS3_BusCod = P001R9_n111TTBUS3_BusCod[0] ;
            A112TTBUS3_BusPar = P001R9_A112TTBUS3_BusPar[0] ;
            n112TTBUS3_BusPar = P001R9_n112TTBUS3_BusPar[0] ;
            A106TTBUS3_NroAsoc = P001R9_A106TTBUS3_NroAsoc[0] ;
            AV17TTBUS3_HdwId = A108TTBUS3_HdwId ;
            AV18TTBUS3_BusEmp = A109TTBUS3_BusEmp ;
            AV19TTBUS3_BusRub = A110TTBUS3_BusRub ;
            AV20TTBUS3_BusCod = A111TTBUS3_BusCod ;
            AV21TTBUS3_BusPar = A112TTBUS3_BusPar ;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(7);
         }
         pr_default.close(7);
      }

      protected void S1286( )
      {
         /* 'GUARDAR ASOCIACIÓN' Routine */
         new ptbus043(context ).execute(  AV23TTBUS3_IdBien, out  AV22TTBUS3_NroAsoc) ;
         /*
            INSERT RECORD ON TABLE TTBUS003

         */
         A105TTBUS3_IdBien = AV23TTBUS3_IdBien ;
         A106TTBUS3_NroAsoc = AV22TTBUS3_NroAsoc ;
         A107TTBUS3_Sist = AV16TTBUS3_Sist ;
         A108TTBUS3_HdwId = AV17TTBUS3_HdwId ;
         n108TTBUS3_HdwId = false ;
         A109TTBUS3_BusEmp = AV18TTBUS3_BusEmp ;
         n109TTBUS3_BusEmp = false ;
         A110TTBUS3_BusRub = AV19TTBUS3_BusRub ;
         n110TTBUS3_BusRub = false ;
         A111TTBUS3_BusCod = AV20TTBUS3_BusCod ;
         n111TTBUS3_BusCod = false ;
         A112TTBUS3_BusPar = AV21TTBUS3_BusPar ;
         n112TTBUS3_BusPar = false ;
         A113TTBUS3_Usuario = AV15USUARIO ;
         A114TTBUS3_FechaAsoc = DateTimeUtil.Now( ) ;
         A115TTBUS3_MaquinaAsoc = GXUtil.WrkSt( context) ;
         /* Using cursor P001R10 */
         pr_default.execute(8, new Object[] {A105TTBUS3_IdBien, A106TTBUS3_NroAsoc, A107TTBUS3_Sist, n108TTBUS3_HdwId, A108TTBUS3_HdwId, n109TTBUS3_BusEmp, A109TTBUS3_BusEmp, n110TTBUS3_BusRub, A110TTBUS3_BusRub, n111TTBUS3_BusCod, A111TTBUS3_BusCod, n112TTBUS3_BusPar, A112TTBUS3_BusPar, A113TTBUS3_Usuario, A114TTBUS3_FechaAsoc, A115TTBUS3_MaquinaAsoc});
         pr_default.close(8);
         if ( (pr_default.getStatus(8) == 1) )
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

      protected void cleanup( )
      {
         context.CommitDataStores("PTBUS030");
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
         P001R2_A11TTBUS_Id = new int[1] ;
         P001R2_A8BUS_EMP = new String[] {""} ;
         P001R2_n8BUS_EMP = new bool[] {false} ;
         P001R2_A1BUS_RUB = new short[1] ;
         P001R2_n1BUS_RUB = new bool[] {false} ;
         P001R2_A3BUS_COD = new short[1] ;
         P001R2_n3BUS_COD = new bool[] {false} ;
         P001R2_A4BUS_PAR = new short[1] ;
         P001R2_n4BUS_PAR = new bool[] {false} ;
         A8BUS_EMP = "" ;
         AV18TTBUS3_BusEmp = "" ;
         P001R4_A11TTBUS_Id = new int[1] ;
         P001R4_A8BUS_EMP = new String[] {""} ;
         P001R4_n8BUS_EMP = new bool[] {false} ;
         P001R4_A1BUS_RUB = new short[1] ;
         P001R4_n1BUS_RUB = new bool[] {false} ;
         P001R4_A3BUS_COD = new short[1] ;
         P001R4_n3BUS_COD = new bool[] {false} ;
         P001R4_A4BUS_PAR = new short[1] ;
         P001R4_n4BUS_PAR = new bool[] {false} ;
         P001R6_A4BUS_PAR = new short[1] ;
         P001R6_n4BUS_PAR = new bool[] {false} ;
         P001R6_A3BUS_COD = new short[1] ;
         P001R6_n3BUS_COD = new bool[] {false} ;
         P001R6_A1BUS_RUB = new short[1] ;
         P001R6_n1BUS_RUB = new bool[] {false} ;
         P001R6_A8BUS_EMP = new String[] {""} ;
         P001R6_n8BUS_EMP = new bool[] {false} ;
         P001R6_A54BUS_DES = new String[] {""} ;
         A54BUS_DES = "" ;
         AV13BUS_DES = "" ;
         P001R7_A11TTBUS_Id = new int[1] ;
         P001R7_A8BUS_EMP = new String[] {""} ;
         P001R7_n8BUS_EMP = new bool[] {false} ;
         P001R7_A1BUS_RUB = new short[1] ;
         P001R7_n1BUS_RUB = new bool[] {false} ;
         P001R7_A3BUS_COD = new short[1] ;
         P001R7_n3BUS_COD = new bool[] {false} ;
         P001R7_A4BUS_PAR = new short[1] ;
         P001R7_n4BUS_PAR = new bool[] {false} ;
         P001R7_A12TTBUS_Descripcion = new String[] {""} ;
         A12TTBUS_Descripcion = "" ;
         P001R9_A105TTBUS3_IdBien = new int[1] ;
         P001R9_A108TTBUS3_HdwId = new short[1] ;
         P001R9_n108TTBUS3_HdwId = new bool[] {false} ;
         P001R9_A109TTBUS3_BusEmp = new String[] {""} ;
         P001R9_n109TTBUS3_BusEmp = new bool[] {false} ;
         P001R9_A110TTBUS3_BusRub = new short[1] ;
         P001R9_n110TTBUS3_BusRub = new bool[] {false} ;
         P001R9_A111TTBUS3_BusCod = new short[1] ;
         P001R9_n111TTBUS3_BusCod = new bool[] {false} ;
         P001R9_A112TTBUS3_BusPar = new short[1] ;
         P001R9_n112TTBUS3_BusPar = new bool[] {false} ;
         P001R9_A106TTBUS3_NroAsoc = new int[1] ;
         A109TTBUS3_BusEmp = "" ;
         A113TTBUS3_Usuario = "" ;
         A114TTBUS3_FechaAsoc = (DateTime)(DateTime.MinValue) ;
         A115TTBUS3_MaquinaAsoc = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus030__default(),
            new Object[][] {
                new Object[] {
               P001R2_A11TTBUS_Id, P001R2_A8BUS_EMP, P001R2_n8BUS_EMP, P001R2_A1BUS_RUB, P001R2_n1BUS_RUB, P001R2_A3BUS_COD, P001R2_n3BUS_COD, P001R2_A4BUS_PAR, P001R2_n4BUS_PAR
               }
               , new Object[] {
               }
               , new Object[] {
               P001R4_A11TTBUS_Id, P001R4_A8BUS_EMP, P001R4_n8BUS_EMP, P001R4_A1BUS_RUB, P001R4_n1BUS_RUB, P001R4_A3BUS_COD, P001R4_n3BUS_COD, P001R4_A4BUS_PAR, P001R4_n4BUS_PAR
               }
               , new Object[] {
               }
               , new Object[] {
               P001R6_A4BUS_PAR, P001R6_A3BUS_COD, P001R6_A1BUS_RUB, P001R6_A8BUS_EMP, P001R6_A54BUS_DES
               }
               , new Object[] {
               P001R7_A11TTBUS_Id, P001R7_A8BUS_EMP, P001R7_n8BUS_EMP, P001R7_A1BUS_RUB, P001R7_n1BUS_RUB, P001R7_A3BUS_COD, P001R7_n3BUS_COD, P001R7_A4BUS_PAR, P001R7_n4BUS_PAR, P001R7_A12TTBUS_Descripcion
               }
               , new Object[] {
               }
               , new Object[] {
               P001R9_A105TTBUS3_IdBien, P001R9_A108TTBUS3_HdwId, P001R9_n108TTBUS3_HdwId, P001R9_A109TTBUS3_BusEmp, P001R9_n109TTBUS3_BusEmp, P001R9_A110TTBUS3_BusRub, P001R9_n110TTBUS3_BusRub, P001R9_A111TTBUS3_BusCod, P001R9_n111TTBUS3_BusCod, P001R9_A112TTBUS3_BusPar,
               P001R9_n112TTBUS3_BusPar, P001R9_A106TTBUS3_NroAsoc
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV9BUS_RUB ;
      private short AV10BUS_COD ;
      private short AV11BUS_PAR ;
      private short AV16TTBUS3_Sist ;
      private short A1BUS_RUB ;
      private short A3BUS_COD ;
      private short A4BUS_PAR ;
      private short AV19TTBUS3_BusRub ;
      private short AV20TTBUS3_BusCod ;
      private short AV21TTBUS3_BusPar ;
      private short A108TTBUS3_HdwId ;
      private short A110TTBUS3_BusRub ;
      private short A111TTBUS3_BusCod ;
      private short A112TTBUS3_BusPar ;
      private short AV17TTBUS3_HdwId ;
      private short A107TTBUS3_Sist ;
      private int AV12BUS_IDT ;
      private int AV14BUS_IDTa ;
      private int A11TTBUS_Id ;
      private int AV23TTBUS3_IdBien ;
      private int A105TTBUS3_IdBien ;
      private int A106TTBUS3_NroAsoc ;
      private int AV22TTBUS3_NroAsoc ;
      private int GX_INS11 ;
      private String AV8BUS_EMP ;
      private String AV15USUARIO ;
      private String scmdbuf ;
      private String A8BUS_EMP ;
      private String AV18TTBUS3_BusEmp ;
      private String A54BUS_DES ;
      private String AV13BUS_DES ;
      private String A109TTBUS3_BusEmp ;
      private String A113TTBUS3_Usuario ;
      private String A115TTBUS3_MaquinaAsoc ;
      private String Gx_emsg ;
      private DateTime A114TTBUS3_FechaAsoc ;
      private bool n8BUS_EMP ;
      private bool n1BUS_RUB ;
      private bool n3BUS_COD ;
      private bool n4BUS_PAR ;
      private bool returnInSub ;
      private bool n108TTBUS3_HdwId ;
      private bool n109TTBUS3_BusEmp ;
      private bool n110TTBUS3_BusRub ;
      private bool n111TTBUS3_BusCod ;
      private bool n112TTBUS3_BusPar ;
      private String A12TTBUS_Descripcion ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_BUS_EMP ;
      private short aP1_BUS_RUB ;
      private short aP2_BUS_COD ;
      private short aP3_BUS_PAR ;
      private int aP4_BUS_IDT ;
      private int aP5_BUS_IDTa ;
      private String aP6_USUARIO ;
      private IDataStoreProvider pr_default ;
      private int[] P001R2_A11TTBUS_Id ;
      private String[] P001R2_A8BUS_EMP ;
      private bool[] P001R2_n8BUS_EMP ;
      private short[] P001R2_A1BUS_RUB ;
      private bool[] P001R2_n1BUS_RUB ;
      private short[] P001R2_A3BUS_COD ;
      private bool[] P001R2_n3BUS_COD ;
      private short[] P001R2_A4BUS_PAR ;
      private bool[] P001R2_n4BUS_PAR ;
      private int[] P001R4_A11TTBUS_Id ;
      private String[] P001R4_A8BUS_EMP ;
      private bool[] P001R4_n8BUS_EMP ;
      private short[] P001R4_A1BUS_RUB ;
      private bool[] P001R4_n1BUS_RUB ;
      private short[] P001R4_A3BUS_COD ;
      private bool[] P001R4_n3BUS_COD ;
      private short[] P001R4_A4BUS_PAR ;
      private bool[] P001R4_n4BUS_PAR ;
      private short[] P001R6_A4BUS_PAR ;
      private bool[] P001R6_n4BUS_PAR ;
      private short[] P001R6_A3BUS_COD ;
      private bool[] P001R6_n3BUS_COD ;
      private short[] P001R6_A1BUS_RUB ;
      private bool[] P001R6_n1BUS_RUB ;
      private String[] P001R6_A8BUS_EMP ;
      private bool[] P001R6_n8BUS_EMP ;
      private String[] P001R6_A54BUS_DES ;
      private int[] P001R7_A11TTBUS_Id ;
      private String[] P001R7_A8BUS_EMP ;
      private bool[] P001R7_n8BUS_EMP ;
      private short[] P001R7_A1BUS_RUB ;
      private bool[] P001R7_n1BUS_RUB ;
      private short[] P001R7_A3BUS_COD ;
      private bool[] P001R7_n3BUS_COD ;
      private short[] P001R7_A4BUS_PAR ;
      private bool[] P001R7_n4BUS_PAR ;
      private String[] P001R7_A12TTBUS_Descripcion ;
      private int[] P001R9_A105TTBUS3_IdBien ;
      private short[] P001R9_A108TTBUS3_HdwId ;
      private bool[] P001R9_n108TTBUS3_HdwId ;
      private String[] P001R9_A109TTBUS3_BusEmp ;
      private bool[] P001R9_n109TTBUS3_BusEmp ;
      private short[] P001R9_A110TTBUS3_BusRub ;
      private bool[] P001R9_n110TTBUS3_BusRub ;
      private short[] P001R9_A111TTBUS3_BusCod ;
      private bool[] P001R9_n111TTBUS3_BusCod ;
      private short[] P001R9_A112TTBUS3_BusPar ;
      private bool[] P001R9_n112TTBUS3_BusPar ;
      private int[] P001R9_A106TTBUS3_NroAsoc ;
   }

   public class ptbus030__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new UpdateCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new UpdateCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new UpdateCursor(def[8])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001R2 ;
          prmP001R2 = new Object[] {
          new Object[] {"@AV14BUS_IDTa",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001R3 ;
          prmP001R3 = new Object[] {
          new Object[] {"@BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_PAR",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001R4 ;
          prmP001R4 = new Object[] {
          new Object[] {"@AV14BUS_IDTa",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001R5 ;
          prmP001R5 = new Object[] {
          new Object[] {"@BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_PAR",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001R6 ;
          prmP001R6 = new Object[] {
          new Object[] {"@AV8BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@AV9BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11BUS_PAR",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmP001R7 ;
          prmP001R7 = new Object[] {
          new Object[] {"@AV12BUS_IDT",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001R8 ;
          prmP001R8 = new Object[] {
          new Object[] {"@BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_PAR",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@TTBUS_Descripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001R9 ;
          prmP001R9 = new Object[] {
          new Object[] {"@AV23TTBUS3_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001R10 ;
          prmP001R10 = new Object[] {
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
          def= new CursorDef[] {
              new CursorDef("P001R2", "SELECT [TTBUS_Id], [BUS_EMP], [BUS_RUB], [BUS_COD], [BUS_PAR] FROM [TTBUS000] WITH (UPDLOCK) WHERE [TTBUS_Id] = @AV14BUS_IDTa ORDER BY [TTBUS_Id] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001R2,1,0,true,true )
             ,new CursorDef("P001R3", "UPDATE [TTBUS000] SET [BUS_EMP]=@BUS_EMP, [BUS_RUB]=@BUS_RUB, [BUS_COD]=@BUS_COD, [BUS_PAR]=@BUS_PAR  WHERE [TTBUS_Id] = @TTBUS_Id", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001R3)
             ,new CursorDef("P001R4", "SELECT [TTBUS_Id], [BUS_EMP], [BUS_RUB], [BUS_COD], [BUS_PAR] FROM [TTBUS000] WITH (UPDLOCK) WHERE [TTBUS_Id] = @AV14BUS_IDTa ORDER BY [TTBUS_Id] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001R4,1,0,true,true )
             ,new CursorDef("P001R5", "UPDATE [TTBUS000] SET [BUS_EMP]=@BUS_EMP, [BUS_RUB]=@BUS_RUB, [BUS_COD]=@BUS_COD, [BUS_PAR]=@BUS_PAR  WHERE [TTBUS_Id] = @TTBUS_Id", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001R5)
             ,new CursorDef("P001R6", "SELECT [BUS_PAR], [BUS_COD], [BUS_RUB], [BUS_EMP], [BUS_DES] FROM [BUS000] WITH (NOLOCK) WHERE [BUS_EMP] = @AV8BUS_EMP and [BUS_RUB] = @AV9BUS_RUB and [BUS_COD] = @AV10BUS_COD and [BUS_PAR] = @AV11BUS_PAR ORDER BY [BUS_EMP], [BUS_RUB], [BUS_COD], [BUS_PAR] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001R6,1,0,false,true )
             ,new CursorDef("P001R7", "SELECT [TTBUS_Id], [BUS_EMP], [BUS_RUB], [BUS_COD], [BUS_PAR], [TTBUS_Descripcion] FROM [TTBUS000] WITH (UPDLOCK) WHERE [TTBUS_Id] = @AV12BUS_IDT ORDER BY [TTBUS_Id] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001R7,1,0,true,true )
             ,new CursorDef("P001R8", "UPDATE [TTBUS000] SET [BUS_EMP]=@BUS_EMP, [BUS_RUB]=@BUS_RUB, [BUS_COD]=@BUS_COD, [BUS_PAR]=@BUS_PAR, [TTBUS_Descripcion]=@TTBUS_Descripcion  WHERE [TTBUS_Id] = @TTBUS_Id", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001R8)
             ,new CursorDef("P001R9", "SELECT TOP 1 [TTBUS3_IdBien], [TTBUS3_HdwId], [TTBUS3_BusEmp], [TTBUS3_BusRub], [TTBUS3_BusCod], [TTBUS3_BusPar], [TTBUS3_NroAsoc] FROM [TTBUS003] WITH (NOLOCK) WHERE [TTBUS3_IdBien] = @AV23TTBUS3_IdBien ORDER BY [TTBUS3_IdBien], [TTBUS3_NroAsoc] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001R9,1,0,false,true )
             ,new CursorDef("P001R10", "INSERT INTO [TTBUS003] ([TTBUS3_IdBien], [TTBUS3_NroAsoc], [TTBUS3_Sist], [TTBUS3_HdwId], [TTBUS3_BusEmp], [TTBUS3_BusRub], [TTBUS3_BusCod], [TTBUS3_BusPar], [TTBUS3_Usuario], [TTBUS3_FechaAsoc], [TTBUS3_MaquinaAsoc]) VALUES (@TTBUS3_IdBien, @TTBUS3_NroAsoc, @TTBUS3_Sist, @TTBUS3_HdwId, @TTBUS3_BusEmp, @TTBUS3_BusRub, @TTBUS3_BusCod, @TTBUS3_BusPar, @TTBUS3_Usuario, @TTBUS3_FechaAsoc, @TTBUS3_MaquinaAsoc)", GxErrorMask.GX_NOMASK,prmP001R10)
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
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                break;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 50) ;
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                break;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((int[]) buf[11])[0] = rslt.getInt(7) ;
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[7]);
                }
                stmt.SetParameter(5, (int)parms[8]);
                break;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 3 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[7]);
                }
                stmt.SetParameter(5, (int)parms[8]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 6 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[7]);
                }
                stmt.SetParameter(5, (String)parms[8]);
                stmt.SetParameter(6, (int)parms[9]);
                break;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 8 :
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
       }
    }

 }

}
