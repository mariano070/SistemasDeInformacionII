/*
               File: PHDW_REDES
        Description: Obtiene un nuevo ID de red
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:10.83
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
   public class phdw_redes : GXProcedure
   {
      public phdw_redes( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public phdw_redes( IGxContext context )
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
                           out long aP1_Red_Id )
      {
         this.AV9THDW_UBI_COD_ = aP0_THDW_UBI_COD_;
         this.AV8Red_Id = 0 ;
         initialize();
         executePrivate();
         aP1_Red_Id=this.AV8Red_Id;
      }

      public long executeUdp( long aP0_THDW_UBI_COD_ )
      {
         this.AV9THDW_UBI_COD_ = aP0_THDW_UBI_COD_;
         this.AV8Red_Id = 0 ;
         initialize();
         executePrivate();
         aP1_Red_Id=this.AV8Red_Id;
         return AV8Red_Id ;
      }

      public void executeSubmit( long aP0_THDW_UBI_COD_ ,
                                 out long aP1_Red_Id )
      {
         phdw_redes objphdw_redes;
         objphdw_redes = new phdw_redes();
         objphdw_redes.AV9THDW_UBI_COD_ = aP0_THDW_UBI_COD_;
         objphdw_redes.AV8Red_Id = 0 ;
         objphdw_redes.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objphdw_redes.executePrivateCatch ));
         aP1_Red_Id=this.AV8Red_Id;
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
         AV8Red_Id = 0 ;
         /* Using cursor P00292 */
         pr_default.execute(0, new Object[] {AV9THDW_UBI_COD_});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A306THDW_UBI_COD_ = P00292_A306THDW_UBI_COD_[0] ;
            A301Red_Descripcion = P00292_A301Red_Descripcion[0] ;
            A300Red_Id = P00292_A300Red_Id[0] ;
            AV8Red_Id = A300Red_Id ;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV8Red_Id = (long)(AV8Red_Id+1) ;
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
         P00292_A306THDW_UBI_COD_ = new long[1] ;
         P00292_A301Red_Descripcion = new String[] {""} ;
         P00292_A300Red_Id = new long[1] ;
         A301Red_Descripcion = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.phdw_redes__default(),
            new Object[][] {
                new Object[] {
               P00292_A306THDW_UBI_COD_, P00292_A301Red_Descripcion, P00292_A300Red_Id
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private long AV9THDW_UBI_COD_ ;
      private long AV8Red_Id ;
      private long A306THDW_UBI_COD_ ;
      private long A300Red_Id ;
      private String scmdbuf ;
      private String A301Red_Descripcion ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00292_A306THDW_UBI_COD_ ;
      private String[] P00292_A301Red_Descripcion ;
      private long[] P00292_A300Red_Id ;
      private long aP1_Red_Id ;
   }

   public class phdw_redes__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00292 ;
          prmP00292 = new Object[] {
          new Object[] {"@AV9THDW_UBI_COD_",SqlDbType.Decimal,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00292", "SELECT [THDW_UBI_COD_], [Red_Descripcion], [Red_Id] FROM [THDW_REDES] WITH (NOLOCK) WHERE [THDW_UBI_COD_] = @AV9THDW_UBI_COD_ ORDER BY [THDW_UBI_COD_], [Red_Id] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00292,100,0,false,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
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
       }
    }

 }

}
