/*
               File: PHDW_IP_5
        Description: Busca datos de red de hardware
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:10.57
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
   public class phdw_ip_5 : GXProcedure
   {
      public phdw_ip_5( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public phdw_ip_5( IGxContext context )
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

      public void execute( long aP0_THDW_UBI_COD_ ,
                           long aP1_Red_Id ,
                           short aP2_HARDWARE_ID ,
                           out String aP3_Red_DireccionDesde ,
                           out String aP4_Red_DireccionHasta ,
                           out String aP5_Red_Mascara ,
                           out String aP6_Red_PuertaEnlace ,
                           out short aP7_Red_DireccionDesdeB1 ,
                           out short aP8_Red_DireccionDesdeB2 ,
                           out short aP9_Red_DireccionDesdeB3 )
      {
         this.AV18THDW_UBI_COD_ = aP0_THDW_UBI_COD_;
         this.AV17Red_Id = aP1_Red_Id;
         this.AV10HARDWARE_ID = aP2_HARDWARE_ID;
         this.AV21Red_DireccionDesde = "" ;
         this.AV20Red_DireccionHasta = "" ;
         this.AV22Red_Mascara = "" ;
         this.AV23Red_PuertaEnlace = "" ;
         this.AV14Red_DireccionDesdeB1 = 0 ;
         this.AV15Red_DireccionDesdeB2 = 0 ;
         this.AV16Red_DireccionDesdeB3 = 0 ;
         initialize();
         executePrivate();
         aP3_Red_DireccionDesde=this.AV21Red_DireccionDesde;
         aP4_Red_DireccionHasta=this.AV20Red_DireccionHasta;
         aP5_Red_Mascara=this.AV22Red_Mascara;
         aP6_Red_PuertaEnlace=this.AV23Red_PuertaEnlace;
         aP7_Red_DireccionDesdeB1=this.AV14Red_DireccionDesdeB1;
         aP8_Red_DireccionDesdeB2=this.AV15Red_DireccionDesdeB2;
         aP9_Red_DireccionDesdeB3=this.AV16Red_DireccionDesdeB3;
      }

      public short executeUdp( long aP0_THDW_UBI_COD_ ,
                               long aP1_Red_Id ,
                               short aP2_HARDWARE_ID ,
                               out String aP3_Red_DireccionDesde ,
                               out String aP4_Red_DireccionHasta ,
                               out String aP5_Red_Mascara ,
                               out String aP6_Red_PuertaEnlace ,
                               out short aP7_Red_DireccionDesdeB1 ,
                               out short aP8_Red_DireccionDesdeB2 )
      {
         this.AV18THDW_UBI_COD_ = aP0_THDW_UBI_COD_;
         this.AV17Red_Id = aP1_Red_Id;
         this.AV10HARDWARE_ID = aP2_HARDWARE_ID;
         this.AV21Red_DireccionDesde = "" ;
         this.AV20Red_DireccionHasta = "" ;
         this.AV22Red_Mascara = "" ;
         this.AV23Red_PuertaEnlace = "" ;
         this.AV14Red_DireccionDesdeB1 = 0 ;
         this.AV15Red_DireccionDesdeB2 = 0 ;
         this.AV16Red_DireccionDesdeB3 = 0 ;
         initialize();
         executePrivate();
         aP3_Red_DireccionDesde=this.AV21Red_DireccionDesde;
         aP4_Red_DireccionHasta=this.AV20Red_DireccionHasta;
         aP5_Red_Mascara=this.AV22Red_Mascara;
         aP6_Red_PuertaEnlace=this.AV23Red_PuertaEnlace;
         aP7_Red_DireccionDesdeB1=this.AV14Red_DireccionDesdeB1;
         aP8_Red_DireccionDesdeB2=this.AV15Red_DireccionDesdeB2;
         aP9_Red_DireccionDesdeB3=this.AV16Red_DireccionDesdeB3;
         return AV16Red_DireccionDesdeB3 ;
      }

      public void executeSubmit( long aP0_THDW_UBI_COD_ ,
                                 long aP1_Red_Id ,
                                 short aP2_HARDWARE_ID ,
                                 out String aP3_Red_DireccionDesde ,
                                 out String aP4_Red_DireccionHasta ,
                                 out String aP5_Red_Mascara ,
                                 out String aP6_Red_PuertaEnlace ,
                                 out short aP7_Red_DireccionDesdeB1 ,
                                 out short aP8_Red_DireccionDesdeB2 ,
                                 out short aP9_Red_DireccionDesdeB3 )
      {
         phdw_ip_5 objphdw_ip_5;
         objphdw_ip_5 = new phdw_ip_5();
         objphdw_ip_5.AV18THDW_UBI_COD_ = aP0_THDW_UBI_COD_;
         objphdw_ip_5.AV17Red_Id = aP1_Red_Id;
         objphdw_ip_5.AV10HARDWARE_ID = aP2_HARDWARE_ID;
         objphdw_ip_5.AV21Red_DireccionDesde = "" ;
         objphdw_ip_5.AV20Red_DireccionHasta = "" ;
         objphdw_ip_5.AV22Red_Mascara = "" ;
         objphdw_ip_5.AV23Red_PuertaEnlace = "" ;
         objphdw_ip_5.AV14Red_DireccionDesdeB1 = 0 ;
         objphdw_ip_5.AV15Red_DireccionDesdeB2 = 0 ;
         objphdw_ip_5.AV16Red_DireccionDesdeB3 = 0 ;
         objphdw_ip_5.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objphdw_ip_5.executePrivateCatch ));
         aP3_Red_DireccionDesde=this.AV21Red_DireccionDesde;
         aP4_Red_DireccionHasta=this.AV20Red_DireccionHasta;
         aP5_Red_Mascara=this.AV22Red_Mascara;
         aP6_Red_PuertaEnlace=this.AV23Red_PuertaEnlace;
         aP7_Red_DireccionDesdeB1=this.AV14Red_DireccionDesdeB1;
         aP8_Red_DireccionDesdeB2=this.AV15Red_DireccionDesdeB2;
         aP9_Red_DireccionDesdeB3=this.AV16Red_DireccionDesdeB3;
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
         /* Using cursor P00222 */
         pr_default.execute(0, new Object[] {AV18THDW_UBI_COD_, AV17Red_Id});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A300Red_Id = P00222_A300Red_Id[0] ;
            A306THDW_UBI_COD_ = P00222_A306THDW_UBI_COD_[0] ;
            A308Red_DireccionDesdeB1 = P00222_A308Red_DireccionDesdeB1[0] ;
            A309Red_DireccionDesdeB2 = P00222_A309Red_DireccionDesdeB2[0] ;
            A310Red_DireccionDesdeB3 = P00222_A310Red_DireccionDesdeB3[0] ;
            A315Red_DireccionDesdeB4 = P00222_A315Red_DireccionDesdeB4[0] ;
            A316Red_DireccionHastaB1 = P00222_A316Red_DireccionHastaB1[0] ;
            A317Red_DireccionHastaB2 = P00222_A317Red_DireccionHastaB2[0] ;
            A318Red_DireccionHastaB3 = P00222_A318Red_DireccionHastaB3[0] ;
            A319Red_DireccionHastaB4 = P00222_A319Red_DireccionHastaB4[0] ;
            A320Red_MascaraB1 = P00222_A320Red_MascaraB1[0] ;
            A321Red_MascaraB2 = P00222_A321Red_MascaraB2[0] ;
            A322Red_MascaraB3 = P00222_A322Red_MascaraB3[0] ;
            A323Red_MascaraB4 = P00222_A323Red_MascaraB4[0] ;
            A324Red_PuertaEnlaceB1 = P00222_A324Red_PuertaEnlaceB1[0] ;
            A325Red_PuertaEnlaceB2 = P00222_A325Red_PuertaEnlaceB2[0] ;
            A326Red_PuertaEnlaceB3 = P00222_A326Red_PuertaEnlaceB3[0] ;
            A327Red_PuertaEnlaceB4 = P00222_A327Red_PuertaEnlaceB4[0] ;
            AV19SDT_REDES.gxTpr_Red_direcciondesdeb1 = A308Red_DireccionDesdeB1 ;
            AV19SDT_REDES.gxTpr_Red_direcciondesdeb2 = A309Red_DireccionDesdeB2 ;
            AV19SDT_REDES.gxTpr_Red_direcciondesdeb3 = A310Red_DireccionDesdeB3 ;
            AV19SDT_REDES.gxTpr_Red_direcciondesdeb4 = A315Red_DireccionDesdeB4 ;
            AV19SDT_REDES.gxTpr_Red_direccionhastab1 = A316Red_DireccionHastaB1 ;
            AV19SDT_REDES.gxTpr_Red_direccionhastab2 = A317Red_DireccionHastaB2 ;
            AV19SDT_REDES.gxTpr_Red_direccionhastab3 = A318Red_DireccionHastaB3 ;
            AV19SDT_REDES.gxTpr_Red_direccionhastab4 = A319Red_DireccionHastaB4 ;
            AV19SDT_REDES.gxTpr_Red_mascarab1 = A320Red_MascaraB1 ;
            AV19SDT_REDES.gxTpr_Red_mascarab2 = A321Red_MascaraB2 ;
            AV19SDT_REDES.gxTpr_Red_mascarab3 = A322Red_MascaraB3 ;
            AV19SDT_REDES.gxTpr_Red_mascarab4 = A323Red_MascaraB4 ;
            AV19SDT_REDES.gxTpr_Red_puertaenlaceb1 = A324Red_PuertaEnlaceB1 ;
            AV19SDT_REDES.gxTpr_Red_puertaenlaceb2 = A325Red_PuertaEnlaceB2 ;
            AV19SDT_REDES.gxTpr_Red_puertaenlaceb3 = A326Red_PuertaEnlaceB3 ;
            AV19SDT_REDES.gxTpr_Red_puertaenlaceb4 = A327Red_PuertaEnlaceB4 ;
            AV14Red_DireccionDesdeB1 = A308Red_DireccionDesdeB1 ;
            AV15Red_DireccionDesdeB2 = A309Red_DireccionDesdeB2 ;
            AV16Red_DireccionDesdeB3 = A310Red_DireccionDesdeB3 ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         AV21Red_DireccionDesde = StringUtil.Trim( StringUtil.Str( (decimal)(AV19SDT_REDES.gxTpr_Red_direcciondesdeb1), 3, 0)) + "." + StringUtil.Trim( StringUtil.Str( (decimal)(AV19SDT_REDES.gxTpr_Red_direcciondesdeb2), 3, 0)) + "." + StringUtil.Trim( StringUtil.Str( (decimal)(AV19SDT_REDES.gxTpr_Red_direcciondesdeb3), 3, 0)) + "." + StringUtil.Trim( StringUtil.Str( (decimal)(AV19SDT_REDES.gxTpr_Red_direcciondesdeb4), 3, 0)) ;
         AV20Red_DireccionHasta = StringUtil.Trim( StringUtil.Str( (decimal)(AV19SDT_REDES.gxTpr_Red_direccionhastab1), 3, 0)) + "." + StringUtil.Trim( StringUtil.Str( (decimal)(AV19SDT_REDES.gxTpr_Red_direccionhastab2), 3, 0)) + "." + StringUtil.Trim( StringUtil.Str( (decimal)(AV19SDT_REDES.gxTpr_Red_direccionhastab3), 3, 0)) + "." + StringUtil.Trim( StringUtil.Str( (decimal)(AV19SDT_REDES.gxTpr_Red_direccionhastab4), 3, 0)) ;
         AV22Red_Mascara = StringUtil.Trim( StringUtil.Str( (decimal)(AV19SDT_REDES.gxTpr_Red_mascarab1), 3, 0)) + "." + StringUtil.Trim( StringUtil.Str( (decimal)(AV19SDT_REDES.gxTpr_Red_mascarab2), 3, 0)) + "." + StringUtil.Trim( StringUtil.Str( (decimal)(AV19SDT_REDES.gxTpr_Red_mascarab3), 3, 0)) + "." + StringUtil.Trim( StringUtil.Str( (decimal)(AV19SDT_REDES.gxTpr_Red_mascarab4), 3, 0)) ;
         AV23Red_PuertaEnlace = StringUtil.Trim( StringUtil.Str( (decimal)(AV19SDT_REDES.gxTpr_Red_puertaenlaceb1), 3, 0)) + "." + StringUtil.Trim( StringUtil.Str( (decimal)(AV19SDT_REDES.gxTpr_Red_puertaenlaceb2), 3, 0)) + "." + StringUtil.Trim( StringUtil.Str( (decimal)(AV19SDT_REDES.gxTpr_Red_puertaenlaceb3), 3, 0)) + "." + StringUtil.Trim( StringUtil.Str( (decimal)(AV19SDT_REDES.gxTpr_Red_puertaenlaceb4), 3, 0)) ;
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
         P00222_A300Red_Id = new long[1] ;
         P00222_A306THDW_UBI_COD_ = new long[1] ;
         P00222_A308Red_DireccionDesdeB1 = new short[1] ;
         P00222_A309Red_DireccionDesdeB2 = new short[1] ;
         P00222_A310Red_DireccionDesdeB3 = new short[1] ;
         P00222_A315Red_DireccionDesdeB4 = new short[1] ;
         P00222_A316Red_DireccionHastaB1 = new short[1] ;
         P00222_A317Red_DireccionHastaB2 = new short[1] ;
         P00222_A318Red_DireccionHastaB3 = new short[1] ;
         P00222_A319Red_DireccionHastaB4 = new short[1] ;
         P00222_A320Red_MascaraB1 = new short[1] ;
         P00222_A321Red_MascaraB2 = new short[1] ;
         P00222_A322Red_MascaraB3 = new short[1] ;
         P00222_A323Red_MascaraB4 = new short[1] ;
         P00222_A324Red_PuertaEnlaceB1 = new short[1] ;
         P00222_A325Red_PuertaEnlaceB2 = new short[1] ;
         P00222_A326Red_PuertaEnlaceB3 = new short[1] ;
         P00222_A327Red_PuertaEnlaceB4 = new short[1] ;
         AV19SDT_REDES = new SdtSDT_REDES(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.phdw_ip_5__default(),
            new Object[][] {
                new Object[] {
               P00222_A300Red_Id, P00222_A306THDW_UBI_COD_, P00222_A308Red_DireccionDesdeB1, P00222_A309Red_DireccionDesdeB2, P00222_A310Red_DireccionDesdeB3, P00222_A315Red_DireccionDesdeB4, P00222_A316Red_DireccionHastaB1, P00222_A317Red_DireccionHastaB2, P00222_A318Red_DireccionHastaB3, P00222_A319Red_DireccionHastaB4,
               P00222_A320Red_MascaraB1, P00222_A321Red_MascaraB2, P00222_A322Red_MascaraB3, P00222_A323Red_MascaraB4, P00222_A324Red_PuertaEnlaceB1, P00222_A325Red_PuertaEnlaceB2, P00222_A326Red_PuertaEnlaceB3, P00222_A327Red_PuertaEnlaceB4
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV10HARDWARE_ID ;
      private short AV16Red_DireccionDesdeB3 ;
      private short A308Red_DireccionDesdeB1 ;
      private short A309Red_DireccionDesdeB2 ;
      private short A310Red_DireccionDesdeB3 ;
      private short A315Red_DireccionDesdeB4 ;
      private short A316Red_DireccionHastaB1 ;
      private short A317Red_DireccionHastaB2 ;
      private short A318Red_DireccionHastaB3 ;
      private short A319Red_DireccionHastaB4 ;
      private short A320Red_MascaraB1 ;
      private short A321Red_MascaraB2 ;
      private short A322Red_MascaraB3 ;
      private short A323Red_MascaraB4 ;
      private short A324Red_PuertaEnlaceB1 ;
      private short A325Red_PuertaEnlaceB2 ;
      private short A326Red_PuertaEnlaceB3 ;
      private short A327Red_PuertaEnlaceB4 ;
      private short AV14Red_DireccionDesdeB1 ;
      private short AV15Red_DireccionDesdeB2 ;
      private long AV18THDW_UBI_COD_ ;
      private long AV17Red_Id ;
      private long A300Red_Id ;
      private long A306THDW_UBI_COD_ ;
      private String scmdbuf ;
      private String AV21Red_DireccionDesde ;
      private String AV20Red_DireccionHasta ;
      private String AV22Red_Mascara ;
      private String AV23Red_PuertaEnlace ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00222_A300Red_Id ;
      private long[] P00222_A306THDW_UBI_COD_ ;
      private short[] P00222_A308Red_DireccionDesdeB1 ;
      private short[] P00222_A309Red_DireccionDesdeB2 ;
      private short[] P00222_A310Red_DireccionDesdeB3 ;
      private short[] P00222_A315Red_DireccionDesdeB4 ;
      private short[] P00222_A316Red_DireccionHastaB1 ;
      private short[] P00222_A317Red_DireccionHastaB2 ;
      private short[] P00222_A318Red_DireccionHastaB3 ;
      private short[] P00222_A319Red_DireccionHastaB4 ;
      private short[] P00222_A320Red_MascaraB1 ;
      private short[] P00222_A321Red_MascaraB2 ;
      private short[] P00222_A322Red_MascaraB3 ;
      private short[] P00222_A323Red_MascaraB4 ;
      private short[] P00222_A324Red_PuertaEnlaceB1 ;
      private short[] P00222_A325Red_PuertaEnlaceB2 ;
      private short[] P00222_A326Red_PuertaEnlaceB3 ;
      private short[] P00222_A327Red_PuertaEnlaceB4 ;
      private String aP3_Red_DireccionDesde ;
      private String aP4_Red_DireccionHasta ;
      private String aP5_Red_Mascara ;
      private String aP6_Red_PuertaEnlace ;
      private short aP7_Red_DireccionDesdeB1 ;
      private short aP8_Red_DireccionDesdeB2 ;
      private short aP9_Red_DireccionDesdeB3 ;
      private SdtSDT_REDES AV19SDT_REDES ;
   }

   public class phdw_ip_5__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00222 ;
          prmP00222 = new Object[] {
          new Object[] {"@AV18THDW_UBI_COD_",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV17Red_Id",SqlDbType.Decimal,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00222", "SELECT [Red_Id], [THDW_UBI_COD_], [Red_DireccionDesdeB1], [Red_DireccionDesdeB2], [Red_DireccionDesdeB3], [Red_DireccionDesdeB4], [Red_DireccionHastaB1], [Red_DireccionHastaB2], [Red_DireccionHastaB3], [Red_DireccionHastaB4], [Red_MascaraB1], [Red_MascaraB2], [Red_MascaraB3], [Red_MascaraB4], [Red_PuertaEnlaceB1], [Red_PuertaEnlaceB2], [Red_PuertaEnlaceB3], [Red_PuertaEnlaceB4] FROM [THDW_REDES] WITH (NOLOCK) WHERE [THDW_UBI_COD_] = @AV18THDW_UBI_COD_ and [Red_Id] = @AV17Red_Id ORDER BY [THDW_UBI_COD_], [Red_Id] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00222,1,0,false,true )
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
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((short[]) buf[9])[0] = rslt.getShort(10) ;
                ((short[]) buf[10])[0] = rslt.getShort(11) ;
                ((short[]) buf[11])[0] = rslt.getShort(12) ;
                ((short[]) buf[12])[0] = rslt.getShort(13) ;
                ((short[]) buf[13])[0] = rslt.getShort(14) ;
                ((short[]) buf[14])[0] = rslt.getShort(15) ;
                ((short[]) buf[15])[0] = rslt.getShort(16) ;
                ((short[]) buf[16])[0] = rslt.getShort(17) ;
                ((short[]) buf[17])[0] = rslt.getShort(18) ;
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
                stmt.SetParameter(2, (long)parms[1]);
                break;
       }
    }

 }

}
