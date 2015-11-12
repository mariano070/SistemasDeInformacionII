/*
               File: PSEG001
        Description: BORRA SISTEMAS
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/5/2014 11:31:1.38
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
   public class pseg001 : GXProcedure
   {
      public pseg001( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pseg001( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_USUCOD ,
                           ref short aP1_SISCOD )
      {
         this.AV8USUCOD = aP0_USUCOD;
         this.AV9SISCOD = aP1_SISCOD;
         initialize();
         executePrivate();
         aP0_USUCOD=this.AV8USUCOD;
         aP1_SISCOD=this.AV9SISCOD;
      }

      public short executeUdp( ref String aP0_USUCOD )
      {
         this.AV8USUCOD = aP0_USUCOD;
         this.AV9SISCOD = aP1_SISCOD;
         initialize();
         executePrivate();
         aP0_USUCOD=this.AV8USUCOD;
         aP1_SISCOD=this.AV9SISCOD;
         return AV9SISCOD ;
      }

      public void executeSubmit( ref String aP0_USUCOD ,
                                 ref short aP1_SISCOD )
      {
         pseg001 objpseg001;
         objpseg001 = new pseg001();
         objpseg001.AV8USUCOD = aP0_USUCOD;
         objpseg001.AV9SISCOD = aP1_SISCOD;
         objpseg001.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpseg001.executePrivateCatch ));
         aP0_USUCOD=this.AV8USUCOD;
         aP1_SISCOD=this.AV9SISCOD;
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
         /* Optimized DELETE. */
         /* Using cursor P002C2 */
         pr_default.execute(0, new Object[] {AV8USUCOD, AV9SISCOD});
         pr_default.close(0);
         /* End optimized DELETE. */
         /* Optimized DELETE. */
         /* Using cursor P002C3 */
         pr_default.execute(1, new Object[] {AV8USUCOD, AV9SISCOD});
         pr_default.close(1);
         /* End optimized DELETE. */
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PSEG001");
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pseg001__default(),
            new Object[][] {
                new Object[] {
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV9SISCOD ;
      private String AV8USUCOD ;
      private IGxDataStore dsDefault ;
      private String aP0_USUCOD ;
      private short aP1_SISCOD ;
      private IDataStoreProvider pr_default ;
   }

   public class pseg001__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP002C2 ;
          prmP002C2 = new Object[] {
          new Object[] {"@AV8USUCOD",SqlDbType.Char,16,0} ,
          new Object[] {"@AV9SISCOD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP002C3 ;
          prmP002C3 = new Object[] {
          new Object[] {"@AV8USUCOD",SqlDbType.Char,16,0} ,
          new Object[] {"@AV9SISCOD",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002C2", "DELETE FROM [SEG004]  WHERE [USU_COD] = @AV8USUCOD and [SIS_COD] = @AV9SISCOD", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002C2)
             ,new CursorDef("P002C3", "DELETE FROM [SEG004]  WHERE [USU_COD] = @AV8USUCOD and [SIS_COD] = @AV9SISCOD", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002C3)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
       }
    }

 }

}
