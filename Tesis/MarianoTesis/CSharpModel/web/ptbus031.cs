/*
               File: PTBUS031
        Description: Asigna bienes desde trazabilidad a cont. y a hdw.
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/20/2014 13:19:18.65
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
   public class ptbus031 : GXProcedure
   {
      public ptbus031( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus031( IGxContext context )
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

      public void execute( ref int aP0_TTBUS_Id ,
                           ref String aP1_BUS_EMP ,
                           ref short aP2_BUS_RUB ,
                           ref short aP3_BUS_COD ,
                           ref short aP4_BUS_PAR ,
                           ref short aP5_HARDWARE_ID ,
                           ref String aP6_BUS_EMPa ,
                           ref short aP7_BUS_RUBa ,
                           ref short aP8_BUS_CODa ,
                           ref short aP9_BUS_PARa ,
                           ref short aP10_HARDWARE_IDa ,
                           ref String aP11_USUARIO )
      {
         this.AV8TTBUS_Id = aP0_TTBUS_Id;
         this.AV9BUS_EMP = aP1_BUS_EMP;
         this.AV10BUS_RUB = aP2_BUS_RUB;
         this.AV11BUS_COD = aP3_BUS_COD;
         this.AV12BUS_PAR = aP4_BUS_PAR;
         this.AV13HARDWARE_ID = aP5_HARDWARE_ID;
         this.AV14BUS_EMPa = aP6_BUS_EMPa;
         this.AV15BUS_RUBa = aP7_BUS_RUBa;
         this.AV16BUS_CODa = aP8_BUS_CODa;
         this.AV17BUS_PARa = aP9_BUS_PARa;
         this.AV18HARDWARE_IDa = aP10_HARDWARE_IDa;
         this.AV19USUARIO = aP11_USUARIO;
         initialize();
         executePrivate();
         aP0_TTBUS_Id=this.AV8TTBUS_Id;
         aP1_BUS_EMP=this.AV9BUS_EMP;
         aP2_BUS_RUB=this.AV10BUS_RUB;
         aP3_BUS_COD=this.AV11BUS_COD;
         aP4_BUS_PAR=this.AV12BUS_PAR;
         aP5_HARDWARE_ID=this.AV13HARDWARE_ID;
         aP6_BUS_EMPa=this.AV14BUS_EMPa;
         aP7_BUS_RUBa=this.AV15BUS_RUBa;
         aP8_BUS_CODa=this.AV16BUS_CODa;
         aP9_BUS_PARa=this.AV17BUS_PARa;
         aP10_HARDWARE_IDa=this.AV18HARDWARE_IDa;
         aP11_USUARIO=this.AV19USUARIO;
      }

      public String executeUdp( ref int aP0_TTBUS_Id ,
                                ref String aP1_BUS_EMP ,
                                ref short aP2_BUS_RUB ,
                                ref short aP3_BUS_COD ,
                                ref short aP4_BUS_PAR ,
                                ref short aP5_HARDWARE_ID ,
                                ref String aP6_BUS_EMPa ,
                                ref short aP7_BUS_RUBa ,
                                ref short aP8_BUS_CODa ,
                                ref short aP9_BUS_PARa ,
                                ref short aP10_HARDWARE_IDa )
      {
         this.AV8TTBUS_Id = aP0_TTBUS_Id;
         this.AV9BUS_EMP = aP1_BUS_EMP;
         this.AV10BUS_RUB = aP2_BUS_RUB;
         this.AV11BUS_COD = aP3_BUS_COD;
         this.AV12BUS_PAR = aP4_BUS_PAR;
         this.AV13HARDWARE_ID = aP5_HARDWARE_ID;
         this.AV14BUS_EMPa = aP6_BUS_EMPa;
         this.AV15BUS_RUBa = aP7_BUS_RUBa;
         this.AV16BUS_CODa = aP8_BUS_CODa;
         this.AV17BUS_PARa = aP9_BUS_PARa;
         this.AV18HARDWARE_IDa = aP10_HARDWARE_IDa;
         this.AV19USUARIO = aP11_USUARIO;
         initialize();
         executePrivate();
         aP0_TTBUS_Id=this.AV8TTBUS_Id;
         aP1_BUS_EMP=this.AV9BUS_EMP;
         aP2_BUS_RUB=this.AV10BUS_RUB;
         aP3_BUS_COD=this.AV11BUS_COD;
         aP4_BUS_PAR=this.AV12BUS_PAR;
         aP5_HARDWARE_ID=this.AV13HARDWARE_ID;
         aP6_BUS_EMPa=this.AV14BUS_EMPa;
         aP7_BUS_RUBa=this.AV15BUS_RUBa;
         aP8_BUS_CODa=this.AV16BUS_CODa;
         aP9_BUS_PARa=this.AV17BUS_PARa;
         aP10_HARDWARE_IDa=this.AV18HARDWARE_IDa;
         aP11_USUARIO=this.AV19USUARIO;
         return AV19USUARIO ;
      }

      public void executeSubmit( ref int aP0_TTBUS_Id ,
                                 ref String aP1_BUS_EMP ,
                                 ref short aP2_BUS_RUB ,
                                 ref short aP3_BUS_COD ,
                                 ref short aP4_BUS_PAR ,
                                 ref short aP5_HARDWARE_ID ,
                                 ref String aP6_BUS_EMPa ,
                                 ref short aP7_BUS_RUBa ,
                                 ref short aP8_BUS_CODa ,
                                 ref short aP9_BUS_PARa ,
                                 ref short aP10_HARDWARE_IDa ,
                                 ref String aP11_USUARIO )
      {
         ptbus031 objptbus031;
         objptbus031 = new ptbus031();
         objptbus031.AV8TTBUS_Id = aP0_TTBUS_Id;
         objptbus031.AV9BUS_EMP = aP1_BUS_EMP;
         objptbus031.AV10BUS_RUB = aP2_BUS_RUB;
         objptbus031.AV11BUS_COD = aP3_BUS_COD;
         objptbus031.AV12BUS_PAR = aP4_BUS_PAR;
         objptbus031.AV13HARDWARE_ID = aP5_HARDWARE_ID;
         objptbus031.AV14BUS_EMPa = aP6_BUS_EMPa;
         objptbus031.AV15BUS_RUBa = aP7_BUS_RUBa;
         objptbus031.AV16BUS_CODa = aP8_BUS_CODa;
         objptbus031.AV17BUS_PARa = aP9_BUS_PARa;
         objptbus031.AV18HARDWARE_IDa = aP10_HARDWARE_IDa;
         objptbus031.AV19USUARIO = aP11_USUARIO;
         objptbus031.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus031.executePrivateCatch ));
         aP0_TTBUS_Id=this.AV8TTBUS_Id;
         aP1_BUS_EMP=this.AV9BUS_EMP;
         aP2_BUS_RUB=this.AV10BUS_RUB;
         aP3_BUS_COD=this.AV11BUS_COD;
         aP4_BUS_PAR=this.AV12BUS_PAR;
         aP5_HARDWARE_ID=this.AV13HARDWARE_ID;
         aP6_BUS_EMPa=this.AV14BUS_EMPa;
         aP7_BUS_RUBa=this.AV15BUS_RUBa;
         aP8_BUS_CODa=this.AV16BUS_CODa;
         aP9_BUS_PARa=this.AV17BUS_PARa;
         aP10_HARDWARE_IDa=this.AV18HARDWARE_IDa;
         aP11_USUARIO=this.AV19USUARIO;
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
         AV21TTBUS3_Sist = 1 ;
         /* Execute user subroutine: S1162 */
         S1162 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         if ( AV13HARDWARE_ID != AV18HARDWARE_IDa )
         {
            /* Using cursor P000B2 */
            pr_default.execute(0, new Object[] {AV18HARDWARE_IDa});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A10HARDWARE_ID = P000B2_A10HARDWARE_ID[0] ;
               A104HDW_IDT = P000B2_A104HDW_IDT[0] ;
               A104HDW_IDT = 0 ;
               AV22TTBUS3_HdwId = 0 ;
               /* Execute user subroutine: S1275 */
               S1275 ();
               if ( returnInSub )
               {
                  pr_default.close(0);
                  this.cleanup();
                  if (true) return;
               }
               /* Using cursor P000B3 */
               pr_default.execute(1, new Object[] {A104HDW_IDT, A10HARDWARE_ID});
               pr_default.close(1);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            /* Using cursor P000B4 */
            pr_default.execute(2, new Object[] {AV13HARDWARE_ID});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A10HARDWARE_ID = P000B4_A10HARDWARE_ID[0] ;
               A104HDW_IDT = P000B4_A104HDW_IDT[0] ;
               A104HDW_IDT = AV8TTBUS_Id ;
               AV22TTBUS3_HdwId = A10HARDWARE_ID ;
               /* Execute user subroutine: S1275 */
               S1275 ();
               if ( returnInSub )
               {
                  pr_default.close(2);
                  this.cleanup();
                  if (true) return;
               }
               /* Using cursor P000B5 */
               pr_default.execute(3, new Object[] {A104HDW_IDT, A10HARDWARE_ID});
               pr_default.close(3);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(2);
         }
         if ( ( ( StringUtil.StrCmp(AV9BUS_EMP, AV14BUS_EMPa) != 0 ) ) || ( ( AV10BUS_RUB != AV15BUS_RUBa ) ) || ( ( AV11BUS_COD != AV16BUS_CODa ) ) || ( ( AV12BUS_PAR != AV17BUS_PARa ) ) )
         {
            /* Using cursor P000B6 */
            pr_default.execute(4, new Object[] {AV14BUS_EMPa, AV15BUS_RUBa, AV16BUS_CODa, AV17BUS_PARa});
            while ( (pr_default.getStatus(4) != 101) )
            {
               A4BUS_PAR = P000B6_A4BUS_PAR[0] ;
               A3BUS_COD = P000B6_A3BUS_COD[0] ;
               A1BUS_RUB = P000B6_A1BUS_RUB[0] ;
               A8BUS_EMP = P000B6_A8BUS_EMP[0] ;
               A103BUS_IDT = P000B6_A103BUS_IDT[0] ;
               A103BUS_IDT = 0 ;
               AV23TTBUS3_BusEmp = "" ;
               AV24TTBUS3_BusRub = 0 ;
               AV25TTBUS3_BusCod = 0 ;
               AV26TTBUS3_BusPar = 0 ;
               /* Execute user subroutine: S1275 */
               S1275 ();
               if ( returnInSub )
               {
                  pr_default.close(4);
                  this.cleanup();
                  if (true) return;
               }
               /* Using cursor P000B7 */
               pr_default.execute(5, new Object[] {A103BUS_IDT, A8BUS_EMP, A1BUS_RUB, A3BUS_COD, A4BUS_PAR});
               pr_default.close(5);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(4);
            /* Using cursor P000B8 */
            pr_default.execute(6, new Object[] {AV9BUS_EMP, AV10BUS_RUB, AV11BUS_COD, AV12BUS_PAR});
            while ( (pr_default.getStatus(6) != 101) )
            {
               A4BUS_PAR = P000B8_A4BUS_PAR[0] ;
               A3BUS_COD = P000B8_A3BUS_COD[0] ;
               A1BUS_RUB = P000B8_A1BUS_RUB[0] ;
               A8BUS_EMP = P000B8_A8BUS_EMP[0] ;
               A103BUS_IDT = P000B8_A103BUS_IDT[0] ;
               A103BUS_IDT = AV8TTBUS_Id ;
               AV23TTBUS3_BusEmp = A8BUS_EMP ;
               AV24TTBUS3_BusRub = A1BUS_RUB ;
               AV25TTBUS3_BusCod = A3BUS_COD ;
               AV26TTBUS3_BusPar = A4BUS_PAR ;
               /* Execute user subroutine: S1275 */
               S1275 ();
               if ( returnInSub )
               {
                  pr_default.close(6);
                  this.cleanup();
                  if (true) return;
               }
               /* Using cursor P000B9 */
               pr_default.execute(7, new Object[] {A103BUS_IDT, A8BUS_EMP, A1BUS_RUB, A3BUS_COD, A4BUS_PAR});
               pr_default.close(7);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(6);
         }
         this.cleanup();
      }

      protected void S1162( )
      {
         /* 'BUSCAR ESTADO PREVIO A CAMBIOS' Routine */
         /* Using cursor P000B10 */
         pr_default.execute(8, new Object[] {AV8TTBUS_Id});
         while ( (pr_default.getStatus(8) != 101) )
         {
            A105TTBUS3_IdBien = P000B10_A105TTBUS3_IdBien[0] ;
            A108TTBUS3_HdwId = P000B10_A108TTBUS3_HdwId[0] ;
            n108TTBUS3_HdwId = P000B10_n108TTBUS3_HdwId[0] ;
            A109TTBUS3_BusEmp = P000B10_A109TTBUS3_BusEmp[0] ;
            n109TTBUS3_BusEmp = P000B10_n109TTBUS3_BusEmp[0] ;
            A110TTBUS3_BusRub = P000B10_A110TTBUS3_BusRub[0] ;
            n110TTBUS3_BusRub = P000B10_n110TTBUS3_BusRub[0] ;
            A111TTBUS3_BusCod = P000B10_A111TTBUS3_BusCod[0] ;
            n111TTBUS3_BusCod = P000B10_n111TTBUS3_BusCod[0] ;
            A112TTBUS3_BusPar = P000B10_A112TTBUS3_BusPar[0] ;
            n112TTBUS3_BusPar = P000B10_n112TTBUS3_BusPar[0] ;
            A106TTBUS3_NroAsoc = P000B10_A106TTBUS3_NroAsoc[0] ;
            AV22TTBUS3_HdwId = A108TTBUS3_HdwId ;
            AV23TTBUS3_BusEmp = A109TTBUS3_BusEmp ;
            AV24TTBUS3_BusRub = A110TTBUS3_BusRub ;
            AV25TTBUS3_BusCod = A111TTBUS3_BusCod ;
            AV26TTBUS3_BusPar = A112TTBUS3_BusPar ;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(8);
         }
         pr_default.close(8);
      }

      protected void S1275( )
      {
         /* 'GUARDAR ASOCIACIÓN' Routine */
         new ptbus043(context ).execute(  AV8TTBUS_Id, out  AV20TTBUS3_NroAsoc) ;
         /*
            INSERT RECORD ON TABLE TTBUS003

         */
         A105TTBUS3_IdBien = AV8TTBUS_Id ;
         A106TTBUS3_NroAsoc = AV20TTBUS3_NroAsoc ;
         A107TTBUS3_Sist = AV21TTBUS3_Sist ;
         A108TTBUS3_HdwId = AV22TTBUS3_HdwId ;
         n108TTBUS3_HdwId = false ;
         A109TTBUS3_BusEmp = AV23TTBUS3_BusEmp ;
         n109TTBUS3_BusEmp = false ;
         A110TTBUS3_BusRub = AV24TTBUS3_BusRub ;
         n110TTBUS3_BusRub = false ;
         A111TTBUS3_BusCod = AV25TTBUS3_BusCod ;
         n111TTBUS3_BusCod = false ;
         A112TTBUS3_BusPar = AV26TTBUS3_BusPar ;
         n112TTBUS3_BusPar = false ;
         A113TTBUS3_Usuario = AV19USUARIO ;
         A114TTBUS3_FechaAsoc = DateTimeUtil.Now( ) ;
         A115TTBUS3_MaquinaAsoc = GXUtil.WrkSt( context) ;
         /* Using cursor P000B11 */
         pr_default.execute(9, new Object[] {A105TTBUS3_IdBien, A106TTBUS3_NroAsoc, A107TTBUS3_Sist, n108TTBUS3_HdwId, A108TTBUS3_HdwId, n109TTBUS3_BusEmp, A109TTBUS3_BusEmp, n110TTBUS3_BusRub, A110TTBUS3_BusRub, n111TTBUS3_BusCod, A111TTBUS3_BusCod, n112TTBUS3_BusPar, A112TTBUS3_BusPar, A113TTBUS3_Usuario, A114TTBUS3_FechaAsoc, A115TTBUS3_MaquinaAsoc});
         pr_default.close(9);
         if ( (pr_default.getStatus(9) == 1) )
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
         context.CommitDataStores("PTBUS031");
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
         P000B2_A10HARDWARE_ID = new short[1] ;
         P000B2_A104HDW_IDT = new int[1] ;
         P000B4_A10HARDWARE_ID = new short[1] ;
         P000B4_A104HDW_IDT = new int[1] ;
         P000B6_A4BUS_PAR = new short[1] ;
         P000B6_A3BUS_COD = new short[1] ;
         P000B6_A1BUS_RUB = new short[1] ;
         P000B6_A8BUS_EMP = new String[] {""} ;
         P000B6_A103BUS_IDT = new int[1] ;
         A8BUS_EMP = "" ;
         AV23TTBUS3_BusEmp = "" ;
         P000B8_A4BUS_PAR = new short[1] ;
         P000B8_A3BUS_COD = new short[1] ;
         P000B8_A1BUS_RUB = new short[1] ;
         P000B8_A8BUS_EMP = new String[] {""} ;
         P000B8_A103BUS_IDT = new int[1] ;
         P000B10_A105TTBUS3_IdBien = new int[1] ;
         P000B10_A108TTBUS3_HdwId = new short[1] ;
         P000B10_n108TTBUS3_HdwId = new bool[] {false} ;
         P000B10_A109TTBUS3_BusEmp = new String[] {""} ;
         P000B10_n109TTBUS3_BusEmp = new bool[] {false} ;
         P000B10_A110TTBUS3_BusRub = new short[1] ;
         P000B10_n110TTBUS3_BusRub = new bool[] {false} ;
         P000B10_A111TTBUS3_BusCod = new short[1] ;
         P000B10_n111TTBUS3_BusCod = new bool[] {false} ;
         P000B10_A112TTBUS3_BusPar = new short[1] ;
         P000B10_n112TTBUS3_BusPar = new bool[] {false} ;
         P000B10_A106TTBUS3_NroAsoc = new int[1] ;
         A109TTBUS3_BusEmp = "" ;
         A113TTBUS3_Usuario = "" ;
         A114TTBUS3_FechaAsoc = (DateTime)(DateTime.MinValue) ;
         A115TTBUS3_MaquinaAsoc = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus031__default(),
            new Object[][] {
                new Object[] {
               P000B2_A10HARDWARE_ID, P000B2_A104HDW_IDT
               }
               , new Object[] {
               }
               , new Object[] {
               P000B4_A10HARDWARE_ID, P000B4_A104HDW_IDT
               }
               , new Object[] {
               }
               , new Object[] {
               P000B6_A4BUS_PAR, P000B6_A3BUS_COD, P000B6_A1BUS_RUB, P000B6_A8BUS_EMP, P000B6_A103BUS_IDT
               }
               , new Object[] {
               }
               , new Object[] {
               P000B8_A4BUS_PAR, P000B8_A3BUS_COD, P000B8_A1BUS_RUB, P000B8_A8BUS_EMP, P000B8_A103BUS_IDT
               }
               , new Object[] {
               }
               , new Object[] {
               P000B10_A105TTBUS3_IdBien, P000B10_A108TTBUS3_HdwId, P000B10_n108TTBUS3_HdwId, P000B10_A109TTBUS3_BusEmp, P000B10_n109TTBUS3_BusEmp, P000B10_A110TTBUS3_BusRub, P000B10_n110TTBUS3_BusRub, P000B10_A111TTBUS3_BusCod, P000B10_n111TTBUS3_BusCod, P000B10_A112TTBUS3_BusPar,
               P000B10_n112TTBUS3_BusPar, P000B10_A106TTBUS3_NroAsoc
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV10BUS_RUB ;
      private short AV11BUS_COD ;
      private short AV12BUS_PAR ;
      private short AV13HARDWARE_ID ;
      private short AV15BUS_RUBa ;
      private short AV16BUS_CODa ;
      private short AV17BUS_PARa ;
      private short AV18HARDWARE_IDa ;
      private short AV21TTBUS3_Sist ;
      private short A10HARDWARE_ID ;
      private short AV22TTBUS3_HdwId ;
      private short A4BUS_PAR ;
      private short A3BUS_COD ;
      private short A1BUS_RUB ;
      private short AV24TTBUS3_BusRub ;
      private short AV25TTBUS3_BusCod ;
      private short AV26TTBUS3_BusPar ;
      private short A108TTBUS3_HdwId ;
      private short A110TTBUS3_BusRub ;
      private short A111TTBUS3_BusCod ;
      private short A112TTBUS3_BusPar ;
      private short A107TTBUS3_Sist ;
      private int AV8TTBUS_Id ;
      private int A104HDW_IDT ;
      private int A103BUS_IDT ;
      private int A105TTBUS3_IdBien ;
      private int A106TTBUS3_NroAsoc ;
      private int AV20TTBUS3_NroAsoc ;
      private int GX_INS11 ;
      private String AV9BUS_EMP ;
      private String AV14BUS_EMPa ;
      private String AV19USUARIO ;
      private String scmdbuf ;
      private String A8BUS_EMP ;
      private String AV23TTBUS3_BusEmp ;
      private String A109TTBUS3_BusEmp ;
      private String A113TTBUS3_Usuario ;
      private String A115TTBUS3_MaquinaAsoc ;
      private String Gx_emsg ;
      private DateTime A114TTBUS3_FechaAsoc ;
      private bool returnInSub ;
      private bool n108TTBUS3_HdwId ;
      private bool n109TTBUS3_BusEmp ;
      private bool n110TTBUS3_BusRub ;
      private bool n111TTBUS3_BusCod ;
      private bool n112TTBUS3_BusPar ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private int aP0_TTBUS_Id ;
      private String aP1_BUS_EMP ;
      private short aP2_BUS_RUB ;
      private short aP3_BUS_COD ;
      private short aP4_BUS_PAR ;
      private short aP5_HARDWARE_ID ;
      private String aP6_BUS_EMPa ;
      private short aP7_BUS_RUBa ;
      private short aP8_BUS_CODa ;
      private short aP9_BUS_PARa ;
      private short aP10_HARDWARE_IDa ;
      private String aP11_USUARIO ;
      private IDataStoreProvider pr_default ;
      private short[] P000B2_A10HARDWARE_ID ;
      private int[] P000B2_A104HDW_IDT ;
      private short[] P000B4_A10HARDWARE_ID ;
      private int[] P000B4_A104HDW_IDT ;
      private short[] P000B6_A4BUS_PAR ;
      private short[] P000B6_A3BUS_COD ;
      private short[] P000B6_A1BUS_RUB ;
      private String[] P000B6_A8BUS_EMP ;
      private int[] P000B6_A103BUS_IDT ;
      private short[] P000B8_A4BUS_PAR ;
      private short[] P000B8_A3BUS_COD ;
      private short[] P000B8_A1BUS_RUB ;
      private String[] P000B8_A8BUS_EMP ;
      private int[] P000B8_A103BUS_IDT ;
      private int[] P000B10_A105TTBUS3_IdBien ;
      private short[] P000B10_A108TTBUS3_HdwId ;
      private bool[] P000B10_n108TTBUS3_HdwId ;
      private String[] P000B10_A109TTBUS3_BusEmp ;
      private bool[] P000B10_n109TTBUS3_BusEmp ;
      private short[] P000B10_A110TTBUS3_BusRub ;
      private bool[] P000B10_n110TTBUS3_BusRub ;
      private short[] P000B10_A111TTBUS3_BusCod ;
      private bool[] P000B10_n111TTBUS3_BusCod ;
      private short[] P000B10_A112TTBUS3_BusPar ;
      private bool[] P000B10_n112TTBUS3_BusPar ;
      private int[] P000B10_A106TTBUS3_NroAsoc ;
   }

   public class ptbus031__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new UpdateCursor(def[9])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000B2 ;
          prmP000B2 = new Object[] {
          new Object[] {"@AV18HARDWARE_IDa",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP000B3 ;
          prmP000B3 = new Object[] {
          new Object[] {"@HDW_IDT",SqlDbType.Int,8,0} ,
          new Object[] {"@HARDWARE_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP000B4 ;
          prmP000B4 = new Object[] {
          new Object[] {"@AV13HARDWARE_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP000B5 ;
          prmP000B5 = new Object[] {
          new Object[] {"@HDW_IDT",SqlDbType.Int,8,0} ,
          new Object[] {"@HARDWARE_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP000B6 ;
          prmP000B6 = new Object[] {
          new Object[] {"@AV14BUS_EMPa",SqlDbType.Char,1,0} ,
          new Object[] {"@AV15BUS_RUBa",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV16BUS_CODa",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV17BUS_PARa",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmP000B7 ;
          prmP000B7 = new Object[] {
          new Object[] {"@BUS_IDT",SqlDbType.Int,8,0} ,
          new Object[] {"@BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_PAR",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmP000B8 ;
          prmP000B8 = new Object[] {
          new Object[] {"@AV9BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@AV10BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12BUS_PAR",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmP000B9 ;
          prmP000B9 = new Object[] {
          new Object[] {"@BUS_IDT",SqlDbType.Int,8,0} ,
          new Object[] {"@BUS_EMP",SqlDbType.Char,1,0} ,
          new Object[] {"@BUS_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_PAR",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmP000B10 ;
          prmP000B10 = new Object[] {
          new Object[] {"@AV8TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP000B11 ;
          prmP000B11 = new Object[] {
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
              new CursorDef("P000B2", "SELECT [HARDWARE_ID], [HDW_IDT] FROM [HARDWARE] WITH (UPDLOCK) WHERE [HARDWARE_ID] = @AV18HARDWARE_IDa ORDER BY [HARDWARE_ID] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000B2,1,0,true,true )
             ,new CursorDef("P000B3", "UPDATE [HARDWARE] SET [HDW_IDT]=@HDW_IDT  WHERE [HARDWARE_ID] = @HARDWARE_ID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000B3)
             ,new CursorDef("P000B4", "SELECT [HARDWARE_ID], [HDW_IDT] FROM [HARDWARE] WITH (UPDLOCK) WHERE [HARDWARE_ID] = @AV13HARDWARE_ID ORDER BY [HARDWARE_ID] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000B4,1,0,true,true )
             ,new CursorDef("P000B5", "UPDATE [HARDWARE] SET [HDW_IDT]=@HDW_IDT  WHERE [HARDWARE_ID] = @HARDWARE_ID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000B5)
             ,new CursorDef("P000B6", "SELECT [BUS_PAR], [BUS_COD], [BUS_RUB], [BUS_EMP], [BUS_IDT] FROM [BUS000] WITH (UPDLOCK) WHERE [BUS_EMP] = @AV14BUS_EMPa and [BUS_RUB] = @AV15BUS_RUBa and [BUS_COD] = @AV16BUS_CODa and [BUS_PAR] = @AV17BUS_PARa ORDER BY [BUS_EMP], [BUS_RUB], [BUS_COD], [BUS_PAR] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000B6,1,0,true,true )
             ,new CursorDef("P000B7", "UPDATE [BUS000] SET [BUS_IDT]=@BUS_IDT  WHERE [BUS_EMP] = @BUS_EMP AND [BUS_RUB] = @BUS_RUB AND [BUS_COD] = @BUS_COD AND [BUS_PAR] = @BUS_PAR", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000B7)
             ,new CursorDef("P000B8", "SELECT [BUS_PAR], [BUS_COD], [BUS_RUB], [BUS_EMP], [BUS_IDT] FROM [BUS000] WITH (UPDLOCK) WHERE [BUS_EMP] = @AV9BUS_EMP and [BUS_RUB] = @AV10BUS_RUB and [BUS_COD] = @AV11BUS_COD and [BUS_PAR] = @AV12BUS_PAR ORDER BY [BUS_EMP], [BUS_RUB], [BUS_COD], [BUS_PAR] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000B8,1,0,true,true )
             ,new CursorDef("P000B9", "UPDATE [BUS000] SET [BUS_IDT]=@BUS_IDT  WHERE [BUS_EMP] = @BUS_EMP AND [BUS_RUB] = @BUS_RUB AND [BUS_COD] = @BUS_COD AND [BUS_PAR] = @BUS_PAR", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000B9)
             ,new CursorDef("P000B10", "SELECT TOP 1 [TTBUS3_IdBien], [TTBUS3_HdwId], [TTBUS3_BusEmp], [TTBUS3_BusRub], [TTBUS3_BusCod], [TTBUS3_BusPar], [TTBUS3_NroAsoc] FROM [TTBUS003] WITH (NOLOCK) WHERE [TTBUS3_IdBien] = @AV8TTBUS_Id ORDER BY [TTBUS3_IdBien], [TTBUS3_NroAsoc] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000B10,1,0,false,true )
             ,new CursorDef("P000B11", "INSERT INTO [TTBUS003] ([TTBUS3_IdBien], [TTBUS3_NroAsoc], [TTBUS3_Sist], [TTBUS3_HdwId], [TTBUS3_BusEmp], [TTBUS3_BusRub], [TTBUS3_BusCod], [TTBUS3_BusPar], [TTBUS3_Usuario], [TTBUS3_FechaAsoc], [TTBUS3_MaquinaAsoc]) VALUES (@TTBUS3_IdBien, @TTBUS3_NroAsoc, @TTBUS3_Sist, @TTBUS3_HdwId, @TTBUS3_BusEmp, @TTBUS3_BusRub, @TTBUS3_BusCod, @TTBUS3_BusPar, @TTBUS3_Usuario, @TTBUS3_FechaAsoc, @TTBUS3_MaquinaAsoc)", GxErrorMask.GX_NOMASK,prmP000B11)
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                break;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                break;
             case 8 :
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
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                break;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 9 :
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
