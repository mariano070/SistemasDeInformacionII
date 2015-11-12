/*
               File: PSEG000
        Description: AGREGA SISTEMAS
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/5/2014 11:31:1.32
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
   public class pseg000 : GXProcedure
   {
      public pseg000( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pseg000( IGxContext context )
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
         pseg000 objpseg000;
         objpseg000 = new pseg000();
         objpseg000.AV8USUCOD = aP0_USUCOD;
         objpseg000.AV9SISCOD = aP1_SISCOD;
         objpseg000.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpseg000.executePrivateCatch ));
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
         /*
            INSERT RECORD ON TABLE SEG004

         */
         A6USU_COD = AV8USUCOD ;
         A116SIS_COD = AV9SISCOD ;
         /* Using cursor P002F2 */
         pr_default.execute(0, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
         pr_default.close(0);
         if ( (pr_default.getStatus(0) == 1) )
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
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PSEG000");
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
         A6USU_COD = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pseg000__default(),
            new Object[][] {
                new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV9SISCOD ;
      private short A116SIS_COD ;
      private short A126PRG_COD ;
      private int GX_INS21 ;
      private String AV8USUCOD ;
      private String A6USU_COD ;
      private String Gx_emsg ;
      private IGxDataStore dsDefault ;
      private String aP0_USUCOD ;
      private short aP1_SISCOD ;
      private IDataStoreProvider pr_default ;
   }

   public class pseg000__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP002F2 ;
          prmP002F2 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002F2", "INSERT INTO [SEG004] ([USU_COD], [SIS_COD], [PRG_COD]) VALUES (@USU_COD, @SIS_COD, @PRG_COD)", GxErrorMask.GX_NOMASK,prmP002F2)
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
                stmt.SetParameter(3, (short)parms[2]);
                break;
       }
    }

 }

}
