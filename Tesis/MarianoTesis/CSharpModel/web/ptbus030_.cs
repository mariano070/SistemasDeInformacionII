/*
               File: PTBUS030_
        Description: Asigna bienes desde hardware a trazabilidad
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:14.23
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
   public class ptbus030_ : GXProcedure
   {
      public ptbus030_( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus030_( IGxContext context )
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

      public void execute( int aP0_HDW_IDT ,
                           int aP1_HDW_IDTa ,
                           short aP2_HARDWARE_ID ,
                           String aP3_USUARIO )
      {
         this.AV14HDW_IDT = aP0_HDW_IDT;
         this.AV16HDW_IDTa = aP1_HDW_IDTa;
         this.AV15HARDWARE_ID = aP2_HARDWARE_ID;
         this.AV27USUARIO = aP3_USUARIO;
         initialize();
         executePrivate();
      }

      public void executeSubmit( int aP0_HDW_IDT ,
                                 int aP1_HDW_IDTa ,
                                 short aP2_HARDWARE_ID ,
                                 String aP3_USUARIO )
      {
         ptbus030_ objptbus030_;
         objptbus030_ = new ptbus030_();
         objptbus030_.AV14HDW_IDT = aP0_HDW_IDT;
         objptbus030_.AV16HDW_IDTa = aP1_HDW_IDTa;
         objptbus030_.AV15HARDWARE_ID = aP2_HARDWARE_ID;
         objptbus030_.AV27USUARIO = aP3_USUARIO;
         objptbus030_.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus030_.executePrivateCatch ));
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
         AV19TTBUS3_Sist = 3 ;
         if ( AV14HDW_IDT == 0 )
         {
            /* Using cursor P001S2 */
            pr_default.execute(0, new Object[] {AV16HDW_IDTa});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A11TTBUS_Id = P001S2_A11TTBUS_Id[0] ;
               A10HARDWARE_ID = P001S2_A10HARDWARE_ID[0] ;
               n10HARDWARE_ID = P001S2_n10HARDWARE_ID[0] ;
               A10HARDWARE_ID = 0 ;
               n10HARDWARE_ID = false ;
               AV20TTBUS3_IdBien = AV16HDW_IDTa ;
               /* Execute user subroutine: S1145 */
               S1145 ();
               if ( returnInSub )
               {
                  pr_default.close(0);
                  this.cleanup();
                  if (true) return;
               }
               AV21TTBUS3_HdwId = 0 ;
               /* Execute user subroutine: S1258 */
               S1258 ();
               if ( returnInSub )
               {
                  pr_default.close(0);
                  this.cleanup();
                  if (true) return;
               }
               /* Using cursor P001S3 */
               pr_default.execute(1, new Object[] {n10HARDWARE_ID, A10HARDWARE_ID, A11TTBUS_Id});
               pr_default.close(1);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
         }
         else
         {
            /* Using cursor P001S4 */
            pr_default.execute(2, new Object[] {AV16HDW_IDTa});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A11TTBUS_Id = P001S4_A11TTBUS_Id[0] ;
               A10HARDWARE_ID = P001S4_A10HARDWARE_ID[0] ;
               n10HARDWARE_ID = P001S4_n10HARDWARE_ID[0] ;
               A10HARDWARE_ID = 0 ;
               n10HARDWARE_ID = false ;
               AV20TTBUS3_IdBien = AV16HDW_IDTa ;
               /* Execute user subroutine: S1145 */
               S1145 ();
               if ( returnInSub )
               {
                  pr_default.close(2);
                  this.cleanup();
                  if (true) return;
               }
               AV21TTBUS3_HdwId = 0 ;
               /* Execute user subroutine: S1258 */
               S1258 ();
               if ( returnInSub )
               {
                  pr_default.close(2);
                  this.cleanup();
                  if (true) return;
               }
               /* Using cursor P001S5 */
               pr_default.execute(3, new Object[] {n10HARDWARE_ID, A10HARDWARE_ID, A11TTBUS_Id});
               pr_default.close(3);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(2);
            /* Using cursor P001S6 */
            pr_default.execute(4, new Object[] {AV14HDW_IDT});
            while ( (pr_default.getStatus(4) != 101) )
            {
               A11TTBUS_Id = P001S6_A11TTBUS_Id[0] ;
               A10HARDWARE_ID = P001S6_A10HARDWARE_ID[0] ;
               n10HARDWARE_ID = P001S6_n10HARDWARE_ID[0] ;
               A10HARDWARE_ID = AV15HARDWARE_ID ;
               n10HARDWARE_ID = false ;
               AV20TTBUS3_IdBien = AV14HDW_IDT ;
               /* Execute user subroutine: S1145 */
               S1145 ();
               if ( returnInSub )
               {
                  pr_default.close(4);
                  this.cleanup();
                  if (true) return;
               }
               AV21TTBUS3_HdwId = A10HARDWARE_ID ;
               /* Execute user subroutine: S1258 */
               S1258 ();
               if ( returnInSub )
               {
                  pr_default.close(4);
                  this.cleanup();
                  if (true) return;
               }
               /* Using cursor P001S7 */
               pr_default.execute(5, new Object[] {n10HARDWARE_ID, A10HARDWARE_ID, A11TTBUS_Id});
               pr_default.close(5);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(4);
         }
         this.cleanup();
      }

      protected void S1145( )
      {
         /* 'BUSCAR ESTADO PREVIO A CAMBIOS' Routine */
         /* Using cursor P001S8 */
         pr_default.execute(6, new Object[] {AV20TTBUS3_IdBien});
         while ( (pr_default.getStatus(6) != 101) )
         {
            A105TTBUS3_IdBien = P001S8_A105TTBUS3_IdBien[0] ;
            A108TTBUS3_HdwId = P001S8_A108TTBUS3_HdwId[0] ;
            n108TTBUS3_HdwId = P001S8_n108TTBUS3_HdwId[0] ;
            A109TTBUS3_BusEmp = P001S8_A109TTBUS3_BusEmp[0] ;
            n109TTBUS3_BusEmp = P001S8_n109TTBUS3_BusEmp[0] ;
            A110TTBUS3_BusRub = P001S8_A110TTBUS3_BusRub[0] ;
            n110TTBUS3_BusRub = P001S8_n110TTBUS3_BusRub[0] ;
            A111TTBUS3_BusCod = P001S8_A111TTBUS3_BusCod[0] ;
            n111TTBUS3_BusCod = P001S8_n111TTBUS3_BusCod[0] ;
            A112TTBUS3_BusPar = P001S8_A112TTBUS3_BusPar[0] ;
            n112TTBUS3_BusPar = P001S8_n112TTBUS3_BusPar[0] ;
            A106TTBUS3_NroAsoc = P001S8_A106TTBUS3_NroAsoc[0] ;
            AV21TTBUS3_HdwId = A108TTBUS3_HdwId ;
            AV22TTBUS3_BusEmp = A109TTBUS3_BusEmp ;
            AV23TTBUS3_BusRub = A110TTBUS3_BusRub ;
            AV24TTBUS3_BusCod = A111TTBUS3_BusCod ;
            AV25TTBUS3_BusPar = A112TTBUS3_BusPar ;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(6);
         }
         pr_default.close(6);
      }

      protected void S1258( )
      {
         /* 'GUARDAR ASOCIACIÓN' Routine */
         new ptbus043(context ).execute(  AV20TTBUS3_IdBien, out  AV26TTBUS3_NroAsoc) ;
         /*
            INSERT RECORD ON TABLE TTBUS003

         */
         A105TTBUS3_IdBien = AV20TTBUS3_IdBien ;
         A106TTBUS3_NroAsoc = AV26TTBUS3_NroAsoc ;
         A107TTBUS3_Sist = AV19TTBUS3_Sist ;
         A108TTBUS3_HdwId = AV21TTBUS3_HdwId ;
         n108TTBUS3_HdwId = false ;
         A109TTBUS3_BusEmp = AV22TTBUS3_BusEmp ;
         n109TTBUS3_BusEmp = false ;
         A110TTBUS3_BusRub = AV23TTBUS3_BusRub ;
         n110TTBUS3_BusRub = false ;
         A111TTBUS3_BusCod = AV24TTBUS3_BusCod ;
         n111TTBUS3_BusCod = false ;
         A112TTBUS3_BusPar = AV25TTBUS3_BusPar ;
         n112TTBUS3_BusPar = false ;
         A113TTBUS3_Usuario = AV27USUARIO ;
         A114TTBUS3_FechaAsoc = DateTimeUtil.Now( ) ;
         A115TTBUS3_MaquinaAsoc = GXUtil.WrkSt( context) ;
         /* Using cursor P001S9 */
         pr_default.execute(7, new Object[] {A105TTBUS3_IdBien, A106TTBUS3_NroAsoc, A107TTBUS3_Sist, n108TTBUS3_HdwId, A108TTBUS3_HdwId, n109TTBUS3_BusEmp, A109TTBUS3_BusEmp, n110TTBUS3_BusRub, A110TTBUS3_BusRub, n111TTBUS3_BusCod, A111TTBUS3_BusCod, n112TTBUS3_BusPar, A112TTBUS3_BusPar, A113TTBUS3_Usuario, A114TTBUS3_FechaAsoc, A115TTBUS3_MaquinaAsoc});
         pr_default.close(7);
         if ( (pr_default.getStatus(7) == 1) )
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
         context.CommitDataStores("PTBUS030_");
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
         P001S2_A11TTBUS_Id = new int[1] ;
         P001S2_A10HARDWARE_ID = new short[1] ;
         P001S2_n10HARDWARE_ID = new bool[] {false} ;
         P001S4_A11TTBUS_Id = new int[1] ;
         P001S4_A10HARDWARE_ID = new short[1] ;
         P001S4_n10HARDWARE_ID = new bool[] {false} ;
         P001S6_A11TTBUS_Id = new int[1] ;
         P001S6_A10HARDWARE_ID = new short[1] ;
         P001S6_n10HARDWARE_ID = new bool[] {false} ;
         P001S8_A105TTBUS3_IdBien = new int[1] ;
         P001S8_A108TTBUS3_HdwId = new short[1] ;
         P001S8_n108TTBUS3_HdwId = new bool[] {false} ;
         P001S8_A109TTBUS3_BusEmp = new String[] {""} ;
         P001S8_n109TTBUS3_BusEmp = new bool[] {false} ;
         P001S8_A110TTBUS3_BusRub = new short[1] ;
         P001S8_n110TTBUS3_BusRub = new bool[] {false} ;
         P001S8_A111TTBUS3_BusCod = new short[1] ;
         P001S8_n111TTBUS3_BusCod = new bool[] {false} ;
         P001S8_A112TTBUS3_BusPar = new short[1] ;
         P001S8_n112TTBUS3_BusPar = new bool[] {false} ;
         P001S8_A106TTBUS3_NroAsoc = new int[1] ;
         A109TTBUS3_BusEmp = "" ;
         AV22TTBUS3_BusEmp = "" ;
         A113TTBUS3_Usuario = "" ;
         A114TTBUS3_FechaAsoc = (DateTime)(DateTime.MinValue) ;
         A115TTBUS3_MaquinaAsoc = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus030___default(),
            new Object[][] {
                new Object[] {
               P001S2_A11TTBUS_Id, P001S2_A10HARDWARE_ID, P001S2_n10HARDWARE_ID
               }
               , new Object[] {
               }
               , new Object[] {
               P001S4_A11TTBUS_Id, P001S4_A10HARDWARE_ID, P001S4_n10HARDWARE_ID
               }
               , new Object[] {
               }
               , new Object[] {
               P001S6_A11TTBUS_Id, P001S6_A10HARDWARE_ID, P001S6_n10HARDWARE_ID
               }
               , new Object[] {
               }
               , new Object[] {
               P001S8_A105TTBUS3_IdBien, P001S8_A108TTBUS3_HdwId, P001S8_n108TTBUS3_HdwId, P001S8_A109TTBUS3_BusEmp, P001S8_n109TTBUS3_BusEmp, P001S8_A110TTBUS3_BusRub, P001S8_n110TTBUS3_BusRub, P001S8_A111TTBUS3_BusCod, P001S8_n111TTBUS3_BusCod, P001S8_A112TTBUS3_BusPar,
               P001S8_n112TTBUS3_BusPar, P001S8_A106TTBUS3_NroAsoc
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV15HARDWARE_ID ;
      private short AV19TTBUS3_Sist ;
      private short A10HARDWARE_ID ;
      private short AV21TTBUS3_HdwId ;
      private short A108TTBUS3_HdwId ;
      private short A110TTBUS3_BusRub ;
      private short A111TTBUS3_BusCod ;
      private short A112TTBUS3_BusPar ;
      private short AV23TTBUS3_BusRub ;
      private short AV24TTBUS3_BusCod ;
      private short AV25TTBUS3_BusPar ;
      private short A107TTBUS3_Sist ;
      private int AV14HDW_IDT ;
      private int AV16HDW_IDTa ;
      private int A11TTBUS_Id ;
      private int AV20TTBUS3_IdBien ;
      private int A105TTBUS3_IdBien ;
      private int A106TTBUS3_NroAsoc ;
      private int AV26TTBUS3_NroAsoc ;
      private int GX_INS11 ;
      private String AV27USUARIO ;
      private String scmdbuf ;
      private String A109TTBUS3_BusEmp ;
      private String AV22TTBUS3_BusEmp ;
      private String A113TTBUS3_Usuario ;
      private String A115TTBUS3_MaquinaAsoc ;
      private String Gx_emsg ;
      private DateTime A114TTBUS3_FechaAsoc ;
      private bool n10HARDWARE_ID ;
      private bool returnInSub ;
      private bool n108TTBUS3_HdwId ;
      private bool n109TTBUS3_BusEmp ;
      private bool n110TTBUS3_BusRub ;
      private bool n111TTBUS3_BusCod ;
      private bool n112TTBUS3_BusPar ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] P001S2_A11TTBUS_Id ;
      private short[] P001S2_A10HARDWARE_ID ;
      private bool[] P001S2_n10HARDWARE_ID ;
      private int[] P001S4_A11TTBUS_Id ;
      private short[] P001S4_A10HARDWARE_ID ;
      private bool[] P001S4_n10HARDWARE_ID ;
      private int[] P001S6_A11TTBUS_Id ;
      private short[] P001S6_A10HARDWARE_ID ;
      private bool[] P001S6_n10HARDWARE_ID ;
      private int[] P001S8_A105TTBUS3_IdBien ;
      private short[] P001S8_A108TTBUS3_HdwId ;
      private bool[] P001S8_n108TTBUS3_HdwId ;
      private String[] P001S8_A109TTBUS3_BusEmp ;
      private bool[] P001S8_n109TTBUS3_BusEmp ;
      private short[] P001S8_A110TTBUS3_BusRub ;
      private bool[] P001S8_n110TTBUS3_BusRub ;
      private short[] P001S8_A111TTBUS3_BusCod ;
      private bool[] P001S8_n111TTBUS3_BusCod ;
      private short[] P001S8_A112TTBUS3_BusPar ;
      private bool[] P001S8_n112TTBUS3_BusPar ;
      private int[] P001S8_A106TTBUS3_NroAsoc ;
   }

   public class ptbus030___default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001S2 ;
          prmP001S2 = new Object[] {
          new Object[] {"@AV16HDW_IDTa",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001S3 ;
          prmP001S3 = new Object[] {
          new Object[] {"@HARDWARE_ID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001S4 ;
          prmP001S4 = new Object[] {
          new Object[] {"@AV16HDW_IDTa",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001S5 ;
          prmP001S5 = new Object[] {
          new Object[] {"@HARDWARE_ID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001S6 ;
          prmP001S6 = new Object[] {
          new Object[] {"@AV14HDW_IDT",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001S7 ;
          prmP001S7 = new Object[] {
          new Object[] {"@HARDWARE_ID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001S8 ;
          prmP001S8 = new Object[] {
          new Object[] {"@AV20TTBUS3_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001S9 ;
          prmP001S9 = new Object[] {
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
              new CursorDef("P001S2", "SELECT [TTBUS_Id], [HARDWARE_ID] FROM [TTBUS000] WITH (UPDLOCK) WHERE [TTBUS_Id] = @AV16HDW_IDTa ORDER BY [TTBUS_Id] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001S2,1,0,true,true )
             ,new CursorDef("P001S3", "UPDATE [TTBUS000] SET [HARDWARE_ID]=@HARDWARE_ID  WHERE [TTBUS_Id] = @TTBUS_Id", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001S3)
             ,new CursorDef("P001S4", "SELECT [TTBUS_Id], [HARDWARE_ID] FROM [TTBUS000] WITH (UPDLOCK) WHERE [TTBUS_Id] = @AV16HDW_IDTa ORDER BY [TTBUS_Id] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001S4,1,0,true,true )
             ,new CursorDef("P001S5", "UPDATE [TTBUS000] SET [HARDWARE_ID]=@HARDWARE_ID  WHERE [TTBUS_Id] = @TTBUS_Id", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001S5)
             ,new CursorDef("P001S6", "SELECT [TTBUS_Id], [HARDWARE_ID] FROM [TTBUS000] WITH (UPDLOCK) WHERE [TTBUS_Id] = @AV14HDW_IDT ORDER BY [TTBUS_Id] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001S6,1,0,true,true )
             ,new CursorDef("P001S7", "UPDATE [TTBUS000] SET [HARDWARE_ID]=@HARDWARE_ID  WHERE [TTBUS_Id] = @TTBUS_Id", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001S7)
             ,new CursorDef("P001S8", "SELECT TOP 1 [TTBUS3_IdBien], [TTBUS3_HdwId], [TTBUS3_BusEmp], [TTBUS3_BusRub], [TTBUS3_BusCod], [TTBUS3_BusPar], [TTBUS3_NroAsoc] FROM [TTBUS003] WITH (NOLOCK) WHERE [TTBUS3_IdBien] = @AV20TTBUS3_IdBien ORDER BY [TTBUS3_IdBien], [TTBUS3_NroAsoc] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001S8,1,0,false,true )
             ,new CursorDef("P001S9", "INSERT INTO [TTBUS003] ([TTBUS3_IdBien], [TTBUS3_NroAsoc], [TTBUS3_Sist], [TTBUS3_HdwId], [TTBUS3_BusEmp], [TTBUS3_BusRub], [TTBUS3_BusCod], [TTBUS3_BusPar], [TTBUS3_Usuario], [TTBUS3_FechaAsoc], [TTBUS3_MaquinaAsoc]) VALUES (@TTBUS3_IdBien, @TTBUS3_NroAsoc, @TTBUS3_Sist, @TTBUS3_HdwId, @TTBUS3_BusEmp, @TTBUS3_BusRub, @TTBUS3_BusCod, @TTBUS3_BusPar, @TTBUS3_Usuario, @TTBUS3_FechaAsoc, @TTBUS3_MaquinaAsoc)", GxErrorMask.GX_NOMASK,prmP001S9)
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 6 :
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
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                break;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 3 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                break;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 5 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                stmt.SetParameter(2, (int)parms[2]);
                break;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 7 :
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
