/*
               File: PTTBUS000_2
        Description: Chequeos de duplicidad de cod. de hardware y/o de bien de uso en cont.
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/20/2014 13:19:17.7
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
   public class pttbus000_2 : GXProcedure
   {
      public pttbus000_2( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pttbus000_2( IGxContext context )
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

      public void execute( int aP0_TTBUS_Id ,
                           int aP1_TTBUS_IdHardware ,
                           String aP2_TTBUS_IdEmpresa ,
                           short aP3_TTBUS_RubroBien ,
                           short aP4_TTBUS_IdBienDeUso ,
                           short aP5_TTBUS_IdPartida ,
                           out short aP6_dup_hw ,
                           out String aP7_mje_hw ,
                           out short aP8_dup_cont ,
                           out String aP9_mje_cont )
      {
         this.AV17TTBUS_Id = aP0_TTBUS_Id;
         this.AV8TTBUS_IdHardware = aP1_TTBUS_IdHardware;
         this.AV11TTBUS_IdEmpresa = aP2_TTBUS_IdEmpresa;
         this.AV12TTBUS_RubroBien = aP3_TTBUS_RubroBien;
         this.AV13TTBUS_IdBienDeUso = aP4_TTBUS_IdBienDeUso;
         this.AV14TTBUS_IdPartida = aP5_TTBUS_IdPartida;
         this.AV10dup_hw = 0 ;
         this.AV9mje_hw = "" ;
         this.AV15dup_cont = 0 ;
         this.AV16mje_cont = "" ;
         initialize();
         executePrivate();
         aP6_dup_hw=this.AV10dup_hw;
         aP7_mje_hw=this.AV9mje_hw;
         aP8_dup_cont=this.AV15dup_cont;
         aP9_mje_cont=this.AV16mje_cont;
      }

      public String executeUdp( int aP0_TTBUS_Id ,
                                int aP1_TTBUS_IdHardware ,
                                String aP2_TTBUS_IdEmpresa ,
                                short aP3_TTBUS_RubroBien ,
                                short aP4_TTBUS_IdBienDeUso ,
                                short aP5_TTBUS_IdPartida ,
                                out short aP6_dup_hw ,
                                out String aP7_mje_hw ,
                                out short aP8_dup_cont )
      {
         this.AV17TTBUS_Id = aP0_TTBUS_Id;
         this.AV8TTBUS_IdHardware = aP1_TTBUS_IdHardware;
         this.AV11TTBUS_IdEmpresa = aP2_TTBUS_IdEmpresa;
         this.AV12TTBUS_RubroBien = aP3_TTBUS_RubroBien;
         this.AV13TTBUS_IdBienDeUso = aP4_TTBUS_IdBienDeUso;
         this.AV14TTBUS_IdPartida = aP5_TTBUS_IdPartida;
         this.AV10dup_hw = 0 ;
         this.AV9mje_hw = "" ;
         this.AV15dup_cont = 0 ;
         this.AV16mje_cont = "" ;
         initialize();
         executePrivate();
         aP6_dup_hw=this.AV10dup_hw;
         aP7_mje_hw=this.AV9mje_hw;
         aP8_dup_cont=this.AV15dup_cont;
         aP9_mje_cont=this.AV16mje_cont;
         return AV16mje_cont ;
      }

      public void executeSubmit( int aP0_TTBUS_Id ,
                                 int aP1_TTBUS_IdHardware ,
                                 String aP2_TTBUS_IdEmpresa ,
                                 short aP3_TTBUS_RubroBien ,
                                 short aP4_TTBUS_IdBienDeUso ,
                                 short aP5_TTBUS_IdPartida ,
                                 out short aP6_dup_hw ,
                                 out String aP7_mje_hw ,
                                 out short aP8_dup_cont ,
                                 out String aP9_mje_cont )
      {
         pttbus000_2 objpttbus000_2;
         objpttbus000_2 = new pttbus000_2();
         objpttbus000_2.AV17TTBUS_Id = aP0_TTBUS_Id;
         objpttbus000_2.AV8TTBUS_IdHardware = aP1_TTBUS_IdHardware;
         objpttbus000_2.AV11TTBUS_IdEmpresa = aP2_TTBUS_IdEmpresa;
         objpttbus000_2.AV12TTBUS_RubroBien = aP3_TTBUS_RubroBien;
         objpttbus000_2.AV13TTBUS_IdBienDeUso = aP4_TTBUS_IdBienDeUso;
         objpttbus000_2.AV14TTBUS_IdPartida = aP5_TTBUS_IdPartida;
         objpttbus000_2.AV10dup_hw = 0 ;
         objpttbus000_2.AV9mje_hw = "" ;
         objpttbus000_2.AV15dup_cont = 0 ;
         objpttbus000_2.AV16mje_cont = "" ;
         objpttbus000_2.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpttbus000_2.executePrivateCatch ));
         aP6_dup_hw=this.AV10dup_hw;
         aP7_mje_hw=this.AV9mje_hw;
         aP8_dup_cont=this.AV15dup_cont;
         aP9_mje_cont=this.AV16mje_cont;
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
         if ( AV8TTBUS_IdHardware != 0 )
         {
            /* Using cursor P00082 */
            pr_default.execute(0, new Object[] {AV8TTBUS_IdHardware, AV17TTBUS_Id});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A10HARDWARE_ID = P00082_A10HARDWARE_ID[0] ;
               n10HARDWARE_ID = P00082_n10HARDWARE_ID[0] ;
               A11TTBUS_Id = P00082_A11TTBUS_Id[0] ;
               AV10dup_hw = 1 ;
               AV9mje_hw = "EL BIEN Nº " + StringUtil.Trim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)) + " YA TIENE ASOCIADO EL CÓD. DE HARDWARE " + StringUtil.Trim( StringUtil.Str( (decimal)(AV8TTBUS_IdHardware), 8, 0)) + ". NO PUEDE HABER MÁS DE UN BIEN ASOCIADO A ESE CÓDIGO DE HARDWARE." ;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(0);
            }
            pr_default.close(0);
         }
         if ( ( ( StringUtil.StrCmp(AV11TTBUS_IdEmpresa, "") != 0 ) ) || ( ( AV12TTBUS_RubroBien != 0 ) ) || ( ( AV13TTBUS_IdBienDeUso != 0 ) ) || ( ( AV14TTBUS_IdPartida != 0 ) ) )
         {
            /* Using cursor P00083 */
            pr_default.execute(1, new Object[] {AV11TTBUS_IdEmpresa, AV12TTBUS_RubroBien, AV13TTBUS_IdBienDeUso, AV14TTBUS_IdPartida, AV17TTBUS_Id});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A4BUS_PAR = P00083_A4BUS_PAR[0] ;
               n4BUS_PAR = P00083_n4BUS_PAR[0] ;
               A3BUS_COD = P00083_A3BUS_COD[0] ;
               n3BUS_COD = P00083_n3BUS_COD[0] ;
               A1BUS_RUB = P00083_A1BUS_RUB[0] ;
               n1BUS_RUB = P00083_n1BUS_RUB[0] ;
               A8BUS_EMP = P00083_A8BUS_EMP[0] ;
               n8BUS_EMP = P00083_n8BUS_EMP[0] ;
               A11TTBUS_Id = P00083_A11TTBUS_Id[0] ;
               AV15dup_cont = 1 ;
               AV16mje_cont = "EL BIEN Nº " + StringUtil.Trim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)) + " YA TIENE ASOCIADO  EL CÓD. DE EMPRESA " + StringUtil.Trim( A8BUS_EMP) + ", EL RUBRO " + StringUtil.Trim( StringUtil.Str( (decimal)(A1BUS_RUB), 8, 0)) + ",  EL CÓD. DE BIEN " + StringUtil.Trim( StringUtil.Str( (decimal)(A3BUS_COD), 8, 0)) + " Y LA PARTIDA " + StringUtil.Trim( StringUtil.Str( (decimal)(A4BUS_PAR), 8, 0)) + ". NO PUEDE HABER MÁS DE UN BIEN ASOCIADO A ESOS CÓDIGOS DE CONTABILIDAD." ;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(1);
            }
            pr_default.close(1);
         }
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
         P00082_A10HARDWARE_ID = new short[1] ;
         P00082_n10HARDWARE_ID = new bool[] {false} ;
         P00082_A11TTBUS_Id = new int[1] ;
         P00083_A4BUS_PAR = new short[1] ;
         P00083_n4BUS_PAR = new bool[] {false} ;
         P00083_A3BUS_COD = new short[1] ;
         P00083_n3BUS_COD = new bool[] {false} ;
         P00083_A1BUS_RUB = new short[1] ;
         P00083_n1BUS_RUB = new bool[] {false} ;
         P00083_A8BUS_EMP = new String[] {""} ;
         P00083_n8BUS_EMP = new bool[] {false} ;
         P00083_A11TTBUS_Id = new int[1] ;
         A8BUS_EMP = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pttbus000_2__default(),
            new Object[][] {
                new Object[] {
               P00082_A10HARDWARE_ID, P00082_n10HARDWARE_ID, P00082_A11TTBUS_Id
               }
               , new Object[] {
               P00083_A4BUS_PAR, P00083_n4BUS_PAR, P00083_A3BUS_COD, P00083_n3BUS_COD, P00083_A1BUS_RUB, P00083_n1BUS_RUB, P00083_A8BUS_EMP, P00083_n8BUS_EMP, P00083_A11TTBUS_Id
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV12TTBUS_RubroBien ;
      private short AV13TTBUS_IdBienDeUso ;
      private short AV14TTBUS_IdPartida ;
      private short A10HARDWARE_ID ;
      private short AV10dup_hw ;
      private short A4BUS_PAR ;
      private short A3BUS_COD ;
      private short A1BUS_RUB ;
      private short AV15dup_cont ;
      private int AV17TTBUS_Id ;
      private int AV8TTBUS_IdHardware ;
      private int A11TTBUS_Id ;
      private String AV11TTBUS_IdEmpresa ;
      private String scmdbuf ;
      private String A8BUS_EMP ;
      private bool n10HARDWARE_ID ;
      private bool n4BUS_PAR ;
      private bool n3BUS_COD ;
      private bool n1BUS_RUB ;
      private bool n8BUS_EMP ;
      private String AV16mje_cont ;
      private String AV9mje_hw ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00082_A10HARDWARE_ID ;
      private bool[] P00082_n10HARDWARE_ID ;
      private int[] P00082_A11TTBUS_Id ;
      private short[] P00083_A4BUS_PAR ;
      private bool[] P00083_n4BUS_PAR ;
      private short[] P00083_A3BUS_COD ;
      private bool[] P00083_n3BUS_COD ;
      private short[] P00083_A1BUS_RUB ;
      private bool[] P00083_n1BUS_RUB ;
      private String[] P00083_A8BUS_EMP ;
      private bool[] P00083_n8BUS_EMP ;
      private int[] P00083_A11TTBUS_Id ;
      private short aP6_dup_hw ;
      private String aP7_mje_hw ;
      private short aP8_dup_cont ;
      private String aP9_mje_cont ;
   }

   public class pttbus000_2__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00082 ;
          prmP00082 = new Object[] {
          new Object[] {"@AV8TTBUS_IdHardware",SqlDbType.Int,8,0} ,
          new Object[] {"@AV17TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP00083 ;
          prmP00083 = new Object[] {
          new Object[] {"@AV11TTBUS_IdEmpresa",SqlDbType.Char,1,0} ,
          new Object[] {"@AV12TTBUS_RubroBien",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13TTBUS_IdBienDeUso",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV14TTBUS_IdPartida",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV17TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00082", "SELECT TOP 1 [HARDWARE_ID], [TTBUS_Id] FROM [TTBUS000] WITH (NOLOCK) WHERE ([HARDWARE_ID] = @AV8TTBUS_IdHardware) AND ([TTBUS_Id] <> @AV17TTBUS_Id) ORDER BY [HARDWARE_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00082,1,0,false,true )
             ,new CursorDef("P00083", "SELECT TOP 1 [BUS_PAR], [BUS_COD], [BUS_RUB], [BUS_EMP], [TTBUS_Id] FROM [TTBUS000] WITH (NOLOCK) WHERE ([BUS_EMP] = @AV11TTBUS_IdEmpresa and [BUS_RUB] = @AV12TTBUS_RubroBien and [BUS_COD] = @AV13TTBUS_IdBienDeUso and [BUS_PAR] = @AV14TTBUS_IdPartida) AND ([TTBUS_Id] <> @AV17TTBUS_Id) ORDER BY [BUS_EMP], [BUS_RUB], [BUS_COD], [BUS_PAR] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00083,1,0,false,true )
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((short[]) buf[4])[0] = rslt.getShort(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((int[]) buf[8])[0] = rslt.getInt(5) ;
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
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                break;
       }
    }

 }

}
