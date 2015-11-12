/*
               File: PTTBUS000_9
        Description: Guarda responsables auxiliares asociados a un movimiento
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:28:59.16
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
   public class pttbus000_9 : GXProcedure
   {
      public pttbus000_9( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pttbus000_9( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_TTBUS2_IdMovimiento )
      {
         this.AV8TTBUS2_IdMovimiento = aP0_TTBUS2_IdMovimiento;
         initialize();
         executePrivate();
         aP0_TTBUS2_IdMovimiento=this.AV8TTBUS2_IdMovimiento;
      }

      public long executeUdp( )
      {
         this.AV8TTBUS2_IdMovimiento = aP0_TTBUS2_IdMovimiento;
         initialize();
         executePrivate();
         aP0_TTBUS2_IdMovimiento=this.AV8TTBUS2_IdMovimiento;
         return AV8TTBUS2_IdMovimiento ;
      }

      public void executeSubmit( ref long aP0_TTBUS2_IdMovimiento )
      {
         pttbus000_9 objpttbus000_9;
         objpttbus000_9 = new pttbus000_9();
         objpttbus000_9.AV8TTBUS2_IdMovimiento = aP0_TTBUS2_IdMovimiento;
         objpttbus000_9.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpttbus000_9.executePrivateCatch ));
         aP0_TTBUS2_IdMovimiento=this.AV8TTBUS2_IdMovimiento;
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
         /* Using cursor P000N2 */
         pr_default.execute(0, new Object[] {AV8TTBUS2_IdMovimiento});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A52TTBUS2_IdMovimiento = P000N2_A52TTBUS2_IdMovimiento[0] ;
            A48TTBUS2_CodPosDesde = P000N2_A48TTBUS2_CodPosDesde[0] ;
            A49TTBUS2_CodPosHacia = P000N2_A49TTBUS2_CodPosHacia[0] ;
            AV9TTBUS2_CodPosDesde = A48TTBUS2_CodPosDesde ;
            AV11TTBUS2_TipoResp = "E" ;
            /* Using cursor P000N3 */
            pr_default.execute(1, new Object[] {AV9TTBUS2_CodPosDesde});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A33TTBUS7_Pos = P000N3_A33TTBUS7_Pos[0] ;
               A51TTBUS7_RespAux = P000N3_A51TTBUS7_RespAux[0] ;
               A39TTBUS7_CodUsuario = P000N3_A39TTBUS7_CodUsuario[0] ;
               AV12TTBUS2_IdUsuario = A39TTBUS7_CodUsuario ;
               if ( A51TTBUS7_RespAux == 1 )
               {
                  /* Execute user subroutine: S1127 */
                  S1127 ();
                  if ( returnInSub )
                  {
                     pr_default.close(1);
                     this.cleanup();
                     if (true) return;
                  }
               }
               pr_default.readNext(1);
            }
            pr_default.close(1);
            AV10TTBUS2_CodPosHacia = A49TTBUS2_CodPosHacia ;
            AV11TTBUS2_TipoResp = "R" ;
            /* Using cursor P000N4 */
            pr_default.execute(2, new Object[] {AV10TTBUS2_CodPosHacia});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A33TTBUS7_Pos = P000N4_A33TTBUS7_Pos[0] ;
               A51TTBUS7_RespAux = P000N4_A51TTBUS7_RespAux[0] ;
               A39TTBUS7_CodUsuario = P000N4_A39TTBUS7_CodUsuario[0] ;
               AV12TTBUS2_IdUsuario = A39TTBUS7_CodUsuario ;
               if ( A51TTBUS7_RespAux == 1 )
               {
                  /* Execute user subroutine: S1127 */
                  S1127 ();
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
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         this.cleanup();
      }

      protected void S1127( )
      {
         /* 'ALTA DATOS' Routine */
         /*
            INSERT RECORD ON TABLE TTBUS002_Det

         */
         A52TTBUS2_IdMovimiento = AV8TTBUS2_IdMovimiento ;
         A53TTBUS2_IdUsuario = AV12TTBUS2_IdUsuario ;
         A102TTBUS2_TipoResp = AV11TTBUS2_TipoResp ;
         /* Using cursor P000N5 */
         pr_default.execute(3, new Object[] {A52TTBUS2_IdMovimiento, A53TTBUS2_IdUsuario, A102TTBUS2_TipoResp});
         pr_default.close(3);
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
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PTTBUS000_9");
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
         P000N2_A52TTBUS2_IdMovimiento = new long[1] ;
         P000N2_A48TTBUS2_CodPosDesde = new short[1] ;
         P000N2_A49TTBUS2_CodPosHacia = new short[1] ;
         AV11TTBUS2_TipoResp = "" ;
         P000N3_A33TTBUS7_Pos = new short[1] ;
         P000N3_A51TTBUS7_RespAux = new short[1] ;
         P000N3_A39TTBUS7_CodUsuario = new String[] {""} ;
         A39TTBUS7_CodUsuario = "" ;
         AV12TTBUS2_IdUsuario = "" ;
         P000N4_A33TTBUS7_Pos = new short[1] ;
         P000N4_A51TTBUS7_RespAux = new short[1] ;
         P000N4_A39TTBUS7_CodUsuario = new String[] {""} ;
         A53TTBUS2_IdUsuario = "" ;
         A102TTBUS2_TipoResp = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pttbus000_9__default(),
            new Object[][] {
                new Object[] {
               P000N2_A52TTBUS2_IdMovimiento, P000N2_A48TTBUS2_CodPosDesde, P000N2_A49TTBUS2_CodPosHacia
               }
               , new Object[] {
               P000N3_A33TTBUS7_Pos, P000N3_A51TTBUS7_RespAux, P000N3_A39TTBUS7_CodUsuario
               }
               , new Object[] {
               P000N4_A33TTBUS7_Pos, P000N4_A51TTBUS7_RespAux, P000N4_A39TTBUS7_CodUsuario
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A48TTBUS2_CodPosDesde ;
      private short A49TTBUS2_CodPosHacia ;
      private short AV9TTBUS2_CodPosDesde ;
      private short A33TTBUS7_Pos ;
      private short A51TTBUS7_RespAux ;
      private short AV10TTBUS2_CodPosHacia ;
      private int GX_INS10 ;
      private long AV8TTBUS2_IdMovimiento ;
      private long A52TTBUS2_IdMovimiento ;
      private String scmdbuf ;
      private String AV11TTBUS2_TipoResp ;
      private String A39TTBUS7_CodUsuario ;
      private String AV12TTBUS2_IdUsuario ;
      private String A53TTBUS2_IdUsuario ;
      private String A102TTBUS2_TipoResp ;
      private String Gx_emsg ;
      private bool returnInSub ;
      private IGxDataStore dsDefault ;
      private long aP0_TTBUS2_IdMovimiento ;
      private IDataStoreProvider pr_default ;
      private long[] P000N2_A52TTBUS2_IdMovimiento ;
      private short[] P000N2_A48TTBUS2_CodPosDesde ;
      private short[] P000N2_A49TTBUS2_CodPosHacia ;
      private short[] P000N3_A33TTBUS7_Pos ;
      private short[] P000N3_A51TTBUS7_RespAux ;
      private String[] P000N3_A39TTBUS7_CodUsuario ;
      private short[] P000N4_A33TTBUS7_Pos ;
      private short[] P000N4_A51TTBUS7_RespAux ;
      private String[] P000N4_A39TTBUS7_CodUsuario ;
   }

   public class pttbus000_9__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new UpdateCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000N2 ;
          prmP000N2 = new Object[] {
          new Object[] {"@AV8TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmP000N3 ;
          prmP000N3 = new Object[] {
          new Object[] {"@AV9TTBUS2_CodPosDesde",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP000N4 ;
          prmP000N4 = new Object[] {
          new Object[] {"@AV10TTBUS2_CodPosHacia",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP000N5 ;
          prmP000N5 = new Object[] {
          new Object[] {"@TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0} ,
          new Object[] {"@TTBUS2_IdUsuario",SqlDbType.Char,16,0} ,
          new Object[] {"@TTBUS2_TipoResp",SqlDbType.Char,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000N2", "SELECT [TTBUS2_IdMovimiento], [TTBUS2_CodPosDesde], [TTBUS2_CodPosHacia] FROM [TTBUS002] WITH (NOLOCK) WHERE [TTBUS2_IdMovimiento] = @AV8TTBUS2_IdMovimiento ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000N2,1,0,true,true )
             ,new CursorDef("P000N3", "SELECT [TTBUS7_Pos], [TTBUS7_RespAux], [TTBUS7_CodUsuario] FROM [TTBUS007Permisos] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @AV9TTBUS2_CodPosDesde ORDER BY [TTBUS7_Pos], [TTBUS7_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000N3,100,0,true,false )
             ,new CursorDef("P000N4", "SELECT [TTBUS7_Pos], [TTBUS7_RespAux], [TTBUS7_CodUsuario] FROM [TTBUS007Permisos] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @AV10TTBUS2_CodPosHacia ORDER BY [TTBUS7_Pos], [TTBUS7_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000N4,100,0,true,false )
             ,new CursorDef("P000N5", "INSERT INTO [TTBUS002_Det] ([TTBUS2_IdMovimiento], [TTBUS2_IdUsuario], [TTBUS2_TipoResp]) VALUES (@TTBUS2_IdMovimiento, @TTBUS2_IdUsuario, @TTBUS2_TipoResp)", GxErrorMask.GX_NOMASK,prmP000N5)
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
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 16) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 16) ;
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
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
       }
    }

 }

}
