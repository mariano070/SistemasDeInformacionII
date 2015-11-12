/*
               File: PTBUSSEG5
        Description: Alta en tablas de seguridad
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:45.85
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
   public class ptbusseg5 : GXProcedure
   {
      public ptbusseg5( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbusseg5( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_USU_COD ,
                           ref String aP1_Modo )
      {
         this.AV8USU_COD = aP0_USU_COD;
         this.AV9Modo = aP1_Modo;
         initialize();
         executePrivate();
         aP0_USU_COD=this.AV8USU_COD;
         aP1_Modo=this.AV9Modo;
      }

      public String executeUdp( ref String aP0_USU_COD )
      {
         this.AV8USU_COD = aP0_USU_COD;
         this.AV9Modo = aP1_Modo;
         initialize();
         executePrivate();
         aP0_USU_COD=this.AV8USU_COD;
         aP1_Modo=this.AV9Modo;
         return AV9Modo ;
      }

      public void executeSubmit( ref String aP0_USU_COD ,
                                 ref String aP1_Modo )
      {
         ptbusseg5 objptbusseg5;
         objptbusseg5 = new ptbusseg5();
         objptbusseg5.AV8USU_COD = aP0_USU_COD;
         objptbusseg5.AV9Modo = aP1_Modo;
         objptbusseg5.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbusseg5.executePrivateCatch ));
         aP0_USU_COD=this.AV8USU_COD;
         aP1_Modo=this.AV9Modo;
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
         if ( StringUtil.StrCmp(AV9Modo, "INS") == 0 )
         {
            /*
               INSERT RECORD ON TABLE SEG004

            */
            A569USU_COD_ = AV8USU_COD ;
            A116SIS_COD = 28 ;
            A126PRG_COD = 79 ;
            /* Using cursor P002Q2 */
            pr_default.execute(0, new Object[] {A569USU_COD_, A116SIS_COD, A126PRG_COD});
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
         }
         else if ( StringUtil.StrCmp(AV9Modo, "DLT") == 0 )
         {
            /* Optimized DELETE. */
            /* Using cursor P002Q3 */
            pr_default.execute(1, new Object[] {AV8USU_COD});
            pr_default.close(1);
            /* End optimized DELETE. */
         }
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PTBUSSEG5");
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
         A569USU_COD_ = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbusseg5__default(),
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

      private short A116SIS_COD ;
      private short A126PRG_COD ;
      private int GX_INS42 ;
      private String AV8USU_COD ;
      private String AV9Modo ;
      private String A569USU_COD_ ;
      private String Gx_emsg ;
      private IGxDataStore dsDefault ;
      private String aP0_USU_COD ;
      private String aP1_Modo ;
      private IDataStoreProvider pr_default ;
   }

   public class ptbusseg5__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP002Q2 ;
          prmP002Q2 = new Object[] {
          new Object[] {"@USU_COD_",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP002Q3 ;
          prmP002Q3 = new Object[] {
          new Object[] {"@AV8USU_COD",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002Q2", "INSERT INTO [SEG004] ([USU_COD_], [SIS_COD], [PRG_COD]) VALUES (@USU_COD_, @SIS_COD, @PRG_COD)", GxErrorMask.GX_NOMASK,prmP002Q2)
             ,new CursorDef("P002Q3", "DELETE FROM [SEG004]  WHERE [USU_COD_] = @AV8USU_COD", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002Q3)
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
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
