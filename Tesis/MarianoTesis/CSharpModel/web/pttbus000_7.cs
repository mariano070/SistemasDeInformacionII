/*
               File: PTTBUS000_7
        Description: Busco descripciones de posiciones
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:58.40
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
   public class pttbus000_7 : GXProcedure
   {
      public pttbus000_7( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pttbus000_7( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( short aP0_TTBUS2_CodPosDesde ,
                           short aP1_TTBUS2_CodPosHacia ,
                           out String aP2_dTTBUS7_Des ,
                           out String aP3_hTTBUS7_Des )
      {
         this.AV33TTBUS2_CodPosDesde = aP0_TTBUS2_CodPosDesde;
         this.AV34TTBUS2_CodPosHacia = aP1_TTBUS2_CodPosHacia;
         this.AV30dTTBUS7_Des = "" ;
         this.AV31hTTBUS7_Des = "" ;
         initialize();
         executePrivate();
         aP2_dTTBUS7_Des=this.AV30dTTBUS7_Des;
         aP3_hTTBUS7_Des=this.AV31hTTBUS7_Des;
      }

      public String executeUdp( short aP0_TTBUS2_CodPosDesde ,
                                short aP1_TTBUS2_CodPosHacia ,
                                out String aP2_dTTBUS7_Des )
      {
         this.AV33TTBUS2_CodPosDesde = aP0_TTBUS2_CodPosDesde;
         this.AV34TTBUS2_CodPosHacia = aP1_TTBUS2_CodPosHacia;
         this.AV30dTTBUS7_Des = "" ;
         this.AV31hTTBUS7_Des = "" ;
         initialize();
         executePrivate();
         aP2_dTTBUS7_Des=this.AV30dTTBUS7_Des;
         aP3_hTTBUS7_Des=this.AV31hTTBUS7_Des;
         return AV31hTTBUS7_Des ;
      }

      public void executeSubmit( short aP0_TTBUS2_CodPosDesde ,
                                 short aP1_TTBUS2_CodPosHacia ,
                                 out String aP2_dTTBUS7_Des ,
                                 out String aP3_hTTBUS7_Des )
      {
         pttbus000_7 objpttbus000_7;
         objpttbus000_7 = new pttbus000_7();
         objpttbus000_7.AV33TTBUS2_CodPosDesde = aP0_TTBUS2_CodPosDesde;
         objpttbus000_7.AV34TTBUS2_CodPosHacia = aP1_TTBUS2_CodPosHacia;
         objpttbus000_7.AV30dTTBUS7_Des = "" ;
         objpttbus000_7.AV31hTTBUS7_Des = "" ;
         objpttbus000_7.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpttbus000_7.executePrivateCatch ));
         aP2_dTTBUS7_Des=this.AV30dTTBUS7_Des;
         aP3_hTTBUS7_Des=this.AV31hTTBUS7_Des;
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
         /* Using cursor P00202 */
         pr_default.execute(0, new Object[] {AV33TTBUS2_CodPosDesde});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A33TTBUS7_Pos = P00202_A33TTBUS7_Pos[0] ;
            A34TTBUS7_Des = P00202_A34TTBUS7_Des[0] ;
            n34TTBUS7_Des = P00202_n34TTBUS7_Des[0] ;
            A34TTBUS7_Des = P00202_A34TTBUS7_Des[0] ;
            n34TTBUS7_Des = P00202_n34TTBUS7_Des[0] ;
            AV30dTTBUS7_Des = A34TTBUS7_Des ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         /* Using cursor P00203 */
         pr_default.execute(1, new Object[] {AV34TTBUS2_CodPosHacia});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A33TTBUS7_Pos = P00203_A33TTBUS7_Pos[0] ;
            A34TTBUS7_Des = P00203_A34TTBUS7_Des[0] ;
            n34TTBUS7_Des = P00203_n34TTBUS7_Des[0] ;
            A34TTBUS7_Des = P00203_A34TTBUS7_Des[0] ;
            n34TTBUS7_Des = P00203_n34TTBUS7_Des[0] ;
            AV31hTTBUS7_Des = A34TTBUS7_Des ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
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
         scmdbuf = "" ;
         P00202_A33TTBUS7_Pos = new short[1] ;
         P00202_A34TTBUS7_Des = new String[] {""} ;
         P00202_n34TTBUS7_Des = new bool[] {false} ;
         A34TTBUS7_Des = "" ;
         P00203_A33TTBUS7_Pos = new short[1] ;
         P00203_A34TTBUS7_Des = new String[] {""} ;
         P00203_n34TTBUS7_Des = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pttbus000_7__default(),
            new Object[][] {
                new Object[] {
               P00202_A33TTBUS7_Pos, P00202_A34TTBUS7_Des, P00202_n34TTBUS7_Des
               }
               , new Object[] {
               P00203_A33TTBUS7_Pos, P00203_A34TTBUS7_Des, P00203_n34TTBUS7_Des
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV33TTBUS2_CodPosDesde ;
      private short AV34TTBUS2_CodPosHacia ;
      private short A33TTBUS7_Pos ;
      private String AV31hTTBUS7_Des ;
      private String scmdbuf ;
      private String A34TTBUS7_Des ;
      private String AV30dTTBUS7_Des ;
      private bool n34TTBUS7_Des ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00202_A33TTBUS7_Pos ;
      private String[] P00202_A34TTBUS7_Des ;
      private bool[] P00202_n34TTBUS7_Des ;
      private short[] P00203_A33TTBUS7_Pos ;
      private String[] P00203_A34TTBUS7_Des ;
      private bool[] P00203_n34TTBUS7_Des ;
      private String aP2_dTTBUS7_Des ;
      private String aP3_hTTBUS7_Des ;
   }

   public class pttbus000_7__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00202 ;
          prmP00202 = new Object[] {
          new Object[] {"@AV33TTBUS2_CodPosDesde",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP00203 ;
          prmP00203 = new Object[] {
          new Object[] {"@AV34TTBUS2_CodPosHacia",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00202", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[W53DES] AS TTBUS7_Des FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) WHERE T1.[TTBUS7_Pos] = @AV33TTBUS2_CodPosDesde ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00202,1,0,false,true )
             ,new CursorDef("P00203", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[W53DES] AS TTBUS7_Des FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) WHERE T1.[TTBUS7_Pos] = @AV34TTBUS2_CodPosHacia ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00203,1,0,false,true )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
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
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
