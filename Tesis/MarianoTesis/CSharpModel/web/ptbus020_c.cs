/*
               File: PTBUS020_C
        Description: Carga sdt de posiciones
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:31.41
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
   public class ptbus020_c : GXProcedure
   {
      public ptbus020_c( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus020_c( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( short aP0_W53POS ,
                           out IGxCollection aP1_Sdt_Posiciones )
      {
         this.AV9W53POS = aP0_W53POS;
         this.AV8Sdt_Posiciones = new GxObjectCollection( context, "SDT_Posiciones", "MarianoTesis", "SdtSDT_Posiciones", "GeneXus.Programs") ;
         initialize();
         executePrivate();
         aP1_Sdt_Posiciones=this.AV8Sdt_Posiciones;
      }

      public IGxCollection executeUdp( short aP0_W53POS )
      {
         this.AV9W53POS = aP0_W53POS;
         this.AV8Sdt_Posiciones = new GxObjectCollection( context, "SDT_Posiciones", "MarianoTesis", "SdtSDT_Posiciones", "GeneXus.Programs") ;
         initialize();
         executePrivate();
         aP1_Sdt_Posiciones=this.AV8Sdt_Posiciones;
         return AV8Sdt_Posiciones ;
      }

      public void executeSubmit( short aP0_W53POS ,
                                 out IGxCollection aP1_Sdt_Posiciones )
      {
         ptbus020_c objptbus020_c;
         objptbus020_c = new ptbus020_c();
         objptbus020_c.AV9W53POS = aP0_W53POS;
         objptbus020_c.AV8Sdt_Posiciones = new GxObjectCollection( context, "SDT_Posiciones", "MarianoTesis", "SdtSDT_Posiciones", "GeneXus.Programs") ;
         objptbus020_c.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus020_c.executePrivateCatch ));
         aP1_Sdt_Posiciones=this.AV8Sdt_Posiciones;
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
         AV8Sdt_Posiciones.Clear();
         AV10item_posicion.gxTpr_W53pos = 0 ;
         /* Using cursor P002V2 */
         pr_default.execute(0, new Object[] {AV9W53POS});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A31W53POS = P002V2_A31W53POS[0] ;
            A32W53DES = P002V2_A32W53DES[0] ;
            AV10item_posicion.gxTpr_W53pos = A31W53POS ;
            AV10item_posicion.gxTpr_W53des = A32W53DES ;
            AV8Sdt_Posiciones.Add(AV10item_posicion, 0);
            AV10item_posicion = new SdtSDT_Posiciones(context) ;
            pr_default.readNext(0);
         }
         pr_default.close(0);
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
         AV10item_posicion = new SdtSDT_Posiciones(context);
         scmdbuf = "" ;
         P002V2_A31W53POS = new short[1] ;
         P002V2_A32W53DES = new String[] {""} ;
         A32W53DES = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus020_c__default(),
            new Object[][] {
                new Object[] {
               P002V2_A31W53POS, P002V2_A32W53DES
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV9W53POS ;
      private short A31W53POS ;
      private String scmdbuf ;
      private String A32W53DES ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P002V2_A31W53POS ;
      private String[] P002V2_A32W53DES ;
      private IGxCollection aP1_Sdt_Posiciones ;
      [ObjectCollection(ItemType=typeof( SdtSDT_Posiciones ))]
      private IGxCollection AV8Sdt_Posiciones ;
      private SdtSDT_Posiciones AV10item_posicion ;
   }

   public class ptbus020_c__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP002V2 ;
          prmP002V2 = new Object[] {
          new Object[] {"@AV9W53POS",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002V2", "SELECT [W53POS], [W53DES] FROM [T53FPOS] WITH (NOLOCK) WHERE ([W53POS] <> @AV9W53POS) AND ([W53POS] <> 998) ORDER BY [W53DES] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002V2,100,0,false,false )
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
       }
    }

 }

}
