/*
               File: TM124FPROV
        Description: MAESTRO DE PROVEEDORES
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:59.61
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
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class tm124fprov : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false ;
         gxfirstwebparm = GetNextPar( ) ;
         gxfirstwebparm_bkp = gxfirstwebparm ;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm, "High") ;
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = GetNextPar( ) ;
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp ;
         }
         if ( ! entryPointCalled )
         {
            AV7PV_NPRO = (int)(NumberUtil.Val( gxfirstwebparm, ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PV_NPRO", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PV_NPRO), 8, 0)));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               Gx_mode = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               AV8SISTEMA = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8SISTEMA", AV8SISTEMA);
               AV9USUARIO = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9USUARIO", AV9USUARIO);
            }
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "MAESTRO DE PROVEEDORES", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtPV_NPRO_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public tm124fprov( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public tm124fprov( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref int aP0_PV_NPRO ,
                           ref String aP1_Gx_mode ,
                           ref String aP2_SISTEMA ,
                           ref String aP3_USUARIO )
      {
         this.AV7PV_NPRO = aP0_PV_NPRO;
         this.Gx_mode = aP1_Gx_mode;
         this.AV8SISTEMA = aP2_SISTEMA;
         this.AV9USUARIO = aP3_USUARIO;
         executePrivate();
         aP0_PV_NPRO=this.AV7PV_NPRO;
         aP1_Gx_mode=this.Gx_mode;
         aP2_SISTEMA=this.AV8SISTEMA;
         aP3_USUARIO=this.AV9USUARIO;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("mptrazabilidad", "GeneXus.Programs.mptrazabilidad", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            MasterPageObj.webExecute();
            if ( context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            wb_table1_2_1841( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1841e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1841( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1841( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1841e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+""+"</legend>") ;
            wb_table3_11_1841( true) ;
         }
         return  ;
      }

      protected void wb_table3_11_1841e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1841e( true) ;
         }
         else
         {
            wb_table1_2_1841e( false) ;
         }
      }

      protected void wb_table3_11_1841( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table4_17_1841( true) ;
         }
         return  ;
      }

      protected void wb_table4_17_1841e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TM124FPROV.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TM124FPROV.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_TM124FPROV.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_11_1841e( true) ;
         }
         else
         {
            wb_table3_11_1841e( false) ;
         }
      }

      protected void wb_table4_17_1841( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpv_npro_Internalname, 1, 1, 0, "Código Proveedor", "", "", "", 0, lblTextblockpv_npro_Jsonclick, "", StyleString, ClassString, "HLP_TM124FPROV.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPV_NPRO_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A28PV_NPRO), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, edtPV_NPRO_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A28PV_NPRO), "ZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(22);\"", 0, edtPV_NPRO_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TM124FPROV.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpv_desc_Internalname, 1, 1, 0, "Descripción", "", "", "", 0, lblTextblockpv_desc_Jsonclick, "", StyleString, ClassString, "HLP_TM124FPROV.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPV_DESC_Internalname, StringUtil.RTrim( A5PV_DESC), "", 30, "chr", 1, "row", 30, 1, edtPV_DESC_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A5PV_DESC, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(27);\"", 0, edtPV_DESC_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TM124FPROV.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_17_1841e( true) ;
         }
         else
         {
            wb_table4_17_1841e( false) ;
         }
      }

      protected void wb_table2_5_1841( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTabletoolbar_Internalname, tblTabletoolbar_Internalname, "", "ViewTable", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "<div style=\"WHITE-SPACE: nowrap\" class=\"ToolbarMain\"/>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_1841e( true) ;
         }
         else
         {
            wb_table2_5_1841e( false) ;
         }
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ! context.localUtil.VCNumber( cgiGet( edtPV_NPRO_Internalname), "ZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtPV_NPRO_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtPV_NPRO_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "PV_NPRO");
                  AnyError = 1 ;
                  GX_FocusControl = edtPV_NPRO_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A28PV_NPRO = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28PV_NPRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A28PV_NPRO), 8, 0)));
               }
               else
               {
                  A28PV_NPRO = (int)(context.localUtil.CToN( cgiGet( edtPV_NPRO_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28PV_NPRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A28PV_NPRO), 8, 0)));
               }
               A5PV_DESC = cgiGet( edtPV_DESC_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5PV_DESC", A5PV_DESC);
               /* Read saved values. */
               Z28PV_NPRO = (int)(context.localUtil.CToN( cgiGet( "Z28PV_NPRO"), ",", ".")) ;
               Z5PV_DESC = cgiGet( "Z5PV_DESC") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV8SISTEMA = cgiGet( "vSISTEMA") ;
               AV9USUARIO = cgiGet( "vUSUARIO") ;
               AV7PV_NPRO = (int)(context.localUtil.CToN( cgiGet( "vPV_NPRO"), ",", ".")) ;
               Gx_mode = cgiGet( "vMODE") ;
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  A28PV_NPRO = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28PV_NPRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A28PV_NPRO), 8, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode41 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode41 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound41 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_180( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert"), 1, "PV_NPRO");
                        AnyError = 1 ;
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName") ;
            EvtGridId = cgiGet( "_EventGridId") ;
            EvtRowId = cgiGet( "_EventRowId") ;
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1) ;
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1) ;
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                     }
                     else
                     {
                     }
                  }
                  context.wbHandled = 1 ;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll1841( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         bttBtn_delete_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtn_delete_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtn_enter_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
            }
            edtPV_NPRO_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPV_NPRO_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPV_NPRO_Enabled), 5, 0)));
            edtPV_DESC_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPV_DESC_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPV_DESC_Enabled), 5, 0)));
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete"), 0, "");
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm"), 0, "");
            }
         }
      }

      protected void CONFIRM_180( )
      {
         BeforeValidate1841( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1841( ) ;
            }
            else
            {
               CheckExtendedTable1841( ) ;
               CloseExtendedTableCursors1841( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
      }

      protected void ResetCaption180( )
      {
      }

      protected void ZM1841( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z5PV_DESC = T00183_A5PV_DESC[0] ;
            }
            else
            {
               Z5PV_DESC = A5PV_DESC ;
            }
         }
         if ( GX_JID == -4 )
         {
            Z28PV_NPRO = A28PV_NPRO ;
            Z5PV_DESC = A5PV_DESC ;
         }
      }

      protected void standaloneNotModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtPV_NPRO_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPV_NPRO_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPV_NPRO_Enabled), 5, 0)));
         }
         else
         {
            edtPV_NPRO_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPV_NPRO_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPV_NPRO_Enabled), 5, 0)));
         }
         bttBtn_delete_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            A28PV_NPRO = AV7PV_NPRO ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28PV_NPRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A28PV_NPRO), 8, 0)));
         }
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtPV_NPRO_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPV_NPRO_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPV_NPRO_Enabled), 5, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)));
         }
         else
         {
            bttBtn_enter_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)));
         }
      }

      protected void Load1841( )
      {
         /* Using cursor T00184 */
         pr_default.execute(2, new Object[] {A28PV_NPRO});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound41 = 1 ;
            A5PV_DESC = T00184_A5PV_DESC[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5PV_DESC", A5PV_DESC);
            ZM1841( -4) ;
         }
         pr_default.close(2);
         OnLoadActions1841( ) ;
      }

      protected void OnLoadActions1841( )
      {
      }

      protected void CheckExtendedTable1841( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors1841( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1841( )
      {
         /* Using cursor T00185 */
         pr_default.execute(3, new Object[] {A28PV_NPRO});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound41 = 1 ;
         }
         else
         {
            RcdFound41 = 0 ;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00183 */
         pr_default.execute(1, new Object[] {A28PV_NPRO});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1841( 4) ;
            RcdFound41 = 1 ;
            A28PV_NPRO = T00183_A28PV_NPRO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28PV_NPRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A28PV_NPRO), 8, 0)));
            A5PV_DESC = T00183_A5PV_DESC[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5PV_DESC", A5PV_DESC);
            Z28PV_NPRO = A28PV_NPRO ;
            sMode41 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load1841( ) ;
            Gx_mode = sMode41 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound41 = 0 ;
            InitializeNonKey1841( ) ;
            sMode41 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode41 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1841( ) ;
         if ( RcdFound41 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound41 = 0 ;
         /* Using cursor T00186 */
         pr_default.execute(4, new Object[] {A28PV_NPRO});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00186_A28PV_NPRO[0] < A28PV_NPRO ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00186_A28PV_NPRO[0] > A28PV_NPRO ) ) )
            {
               A28PV_NPRO = T00186_A28PV_NPRO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28PV_NPRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A28PV_NPRO), 8, 0)));
               RcdFound41 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound41 = 0 ;
         /* Using cursor T00187 */
         pr_default.execute(5, new Object[] {A28PV_NPRO});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00187_A28PV_NPRO[0] > A28PV_NPRO ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00187_A28PV_NPRO[0] < A28PV_NPRO ) ) )
            {
               A28PV_NPRO = T00187_A28PV_NPRO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28PV_NPRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A28PV_NPRO), 8, 0)));
               RcdFound41 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1841( ) ;
         if ( RcdFound41 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "PV_NPRO");
               AnyError = 1 ;
               GX_FocusControl = edtPV_NPRO_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( A28PV_NPRO != Z28PV_NPRO )
            {
               A28PV_NPRO = Z28PV_NPRO ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28PV_NPRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A28PV_NPRO), 8, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "PV_NPRO");
               AnyError = 1 ;
               GX_FocusControl = edtPV_NPRO_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtPV_NPRO_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               Update1841( ) ;
               GX_FocusControl = edtPV_NPRO_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( A28PV_NPRO != Z28PV_NPRO )
            {
               /* Insert record */
               Insert1841( ) ;
               GX_FocusControl = edtPV_NPRO_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "PV_NPRO");
                  AnyError = 1 ;
                  GX_FocusControl = edtPV_NPRO_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Insert record */
                  Insert1841( ) ;
                  GX_FocusControl = edtPV_NPRO_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1 ;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A28PV_NPRO != Z28PV_NPRO )
         {
            A28PV_NPRO = Z28PV_NPRO ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28PV_NPRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A28PV_NPRO), 8, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "PV_NPRO");
            AnyError = 1 ;
            GX_FocusControl = edtPV_NPRO_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtPV_NPRO_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency1841( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00188 */
            pr_default.execute(6, new Object[] {A28PV_NPRO});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"M124FPROV"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(6) == 101) || ( StringUtil.StrCmp(Z5PV_DESC, T00188_A5PV_DESC[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"M124FPROV"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1841( )
      {
         BeforeValidate1841( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1841( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1841( 0) ;
            CheckOptimisticConcurrency1841( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1841( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1841( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00189 */
                     pr_default.execute(7, new Object[] {A28PV_NPRO, A5PV_DESC});
                     pr_default.close(7);
                     if ( (pr_default.getStatus(7) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1 ;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded"), 0, "");
                           ResetCaption180( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
            else
            {
               Load1841( ) ;
            }
            EndLevel1841( ) ;
         }
         CloseExtendedTableCursors1841( ) ;
      }

      protected void Update1841( )
      {
         BeforeValidate1841( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1841( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1841( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1841( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1841( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001810 */
                     pr_default.execute(8, new Object[] {A5PV_DESC, A28PV_NPRO});
                     pr_default.close(8);
                     if ( (pr_default.getStatus(8) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"M124FPROV"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1841( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1 ;
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
            }
            EndLevel1841( ) ;
         }
         CloseExtendedTableCursors1841( ) ;
      }

      protected void DeferredUpdate1841( )
      {
      }

      protected void delete( )
      {
         BeforeValidate1841( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1841( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1841( ) ;
            AfterConfirm1841( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1841( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001811 */
                  pr_default.execute(9, new Object[] {A28PV_NPRO});
                  pr_default.close(9);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1 ;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
         }
         sMode41 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1841( ) ;
         Gx_mode = sMode41 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1841( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T001812 */
            pr_default.execute(10, new Object[] {A28PV_NPRO});
            if ( (pr_default.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Maestro de Bienes de Uso Trazabilizados"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(10);
         }
      }

      protected void EndLevel1841( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(6);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1841( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(4);
            context.CommitDataStores("TM124FPROV");
            if ( AnyError == 0 )
            {
               ConfirmValues180( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(4);
            context.RollbackDataStores("TM124FPROV");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1841( )
      {
         /* Using cursor T001813 */
         pr_default.execute(11);
         RcdFound41 = 0 ;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound41 = 1 ;
            A28PV_NPRO = T001813_A28PV_NPRO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28PV_NPRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A28PV_NPRO), 8, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1841( )
      {
         pr_default.readNext(11);
         RcdFound41 = 0 ;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound41 = 1 ;
            A28PV_NPRO = T001813_A28PV_NPRO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28PV_NPRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A28PV_NPRO), 8, 0)));
         }
      }

      protected void ScanEnd1841( )
      {
      }

      protected void AfterConfirm1841( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1841( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1841( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1841( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1841( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1841( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues180( )
      {
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      public override void RenderHtmlOpenForm( )
      {
         context.WriteHtmlText( "<title>") ;
         context.WriteHtmlText( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         if ( ! context.isSmartDevice( ) )
         {
            context.AddJavascriptSource("gxgral.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         else
         {
            context.AddJavascriptSource("gxapiSD.js", "?42940");
            context.AddJavascriptSource("gxfxSD.js", "?42940");
            context.AddJavascriptSource("gxtypesSD.js", "?42940");
            context.AddJavascriptSource("gxpopupSD.js", "?42940");
            context.AddJavascriptSource("gxfrmutlSD.js", "?42940");
            context.AddJavascriptSource("gxgridSD.js", "?42940");
            context.AddJavascriptSource("JavaScripTableSD.js", "?42940");
            context.AddJavascriptSource("rijndaelSD.js", "?42940");
            context.AddJavascriptSource("gxgralSD.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tm124fprov.aspx") + "?" + UrlEncode("" +AV7PV_NPRO) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV9USUARIO))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z28PV_NPRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z28PV_NPRO), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z5PV_DESC", StringUtil.RTrim( Z5PV_DESC));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV8SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV9USUARIO));
         GxWebStd.gx_hidden_field( context, "vPV_NPRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7PV_NPRO), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         Draw( ) ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "TM124FPROV" ;
      }

      public override String GetPgmdesc( )
      {
         return "MAESTRO DE PROVEEDORES" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("tm124fprov.aspx") + "?" + UrlEncode("" +AV7PV_NPRO) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV9USUARIO)) ;
      }

      protected void InitializeNonKey1841( )
      {
         A5PV_DESC = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5PV_DESC", A5PV_DESC);
      }

      protected void InitAll1841( )
      {
         A28PV_NPRO = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28PV_NPRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A28PV_NPRO), 8, 0)));
         InitializeNonKey1841( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?193000");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("tm124fprov.js", "?193000");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         tblTabletoolbar_Internalname = "TABLETOOLBAR" ;
         lblTextblockpv_npro_Internalname = "TEXTBLOCKPV_NPRO" ;
         edtPV_NPRO_Internalname = "PV_NPRO" ;
         lblTextblockpv_desc_Internalname = "TEXTBLOCKPV_DESC" ;
         edtPV_DESC_Internalname = "PV_DESC" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "MAESTRO DE PROVEEDORES" ;
         edtPV_DESC_Jsonclick = "" ;
         edtPV_DESC_Enabled = 1 ;
         edtPV_NPRO_Jsonclick = "" ;
         edtPV_NPRO_Enabled = 1 ;
         bttBtn_delete_Enabled = 0 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Enabled = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(11);
         pr_default.close(5);
         pr_default.close(4);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         wcpOGx_mode = "" ;
         wcpOAV8SISTEMA = "" ;
         wcpOAV9USUARIO = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Form = new GXWebForm();
         GX_FocusControl = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         TempTags = "" ;
         bttBtn_enter_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         bttBtn_delete_Jsonclick = "" ;
         lblTextblockpv_npro_Jsonclick = "" ;
         lblTextblockpv_desc_Jsonclick = "" ;
         A5PV_DESC = "" ;
         Z5PV_DESC = "" ;
         sMode41 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T00184_A28PV_NPRO = new int[1] ;
         T00184_A5PV_DESC = new String[] {""} ;
         T00185_A28PV_NPRO = new int[1] ;
         T00183_A28PV_NPRO = new int[1] ;
         T00183_A5PV_DESC = new String[] {""} ;
         T00186_A28PV_NPRO = new int[1] ;
         T00187_A28PV_NPRO = new int[1] ;
         T00188_A28PV_NPRO = new int[1] ;
         T00188_A5PV_DESC = new String[] {""} ;
         T001812_A11TTBUS_Id = new int[1] ;
         T001813_A28PV_NPRO = new int[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tm124fprov__default(),
            new Object[][] {
                new Object[] {
               T00182_A28PV_NPRO, T00182_A5PV_DESC
               }
               , new Object[] {
               T00183_A28PV_NPRO, T00183_A5PV_DESC
               }
               , new Object[] {
               T00184_A28PV_NPRO, T00184_A5PV_DESC
               }
               , new Object[] {
               T00185_A28PV_NPRO
               }
               , new Object[] {
               T00186_A28PV_NPRO
               }
               , new Object[] {
               T00187_A28PV_NPRO
               }
               , new Object[] {
               T00188_A28PV_NPRO, T00188_A5PV_DESC
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001812_A11TTBUS_Id
               }
               , new Object[] {
               T001813_A28PV_NPRO
               }
            }
         );
      }

      private short GxWebError ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short RcdFound41 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int wcpOAV7PV_NPRO ;
      private int AV7PV_NPRO ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int A28PV_NPRO ;
      private int edtPV_NPRO_Enabled ;
      private int edtPV_DESC_Enabled ;
      private int Z28PV_NPRO ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String wcpOAV8SISTEMA ;
      private String wcpOAV9USUARIO ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String AV8SISTEMA ;
      private String AV9USUARIO ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtPV_NPRO_Internalname ;
      private String sStyleString ;
      private String tblTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroupdata_Internalname ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockpv_npro_Internalname ;
      private String lblTextblockpv_npro_Jsonclick ;
      private String edtPV_NPRO_Jsonclick ;
      private String lblTextblockpv_desc_Internalname ;
      private String lblTextblockpv_desc_Jsonclick ;
      private String edtPV_DESC_Internalname ;
      private String A5PV_DESC ;
      private String edtPV_DESC_Jsonclick ;
      private String tblTabletoolbar_Internalname ;
      private String Z5PV_DESC ;
      private String sMode41 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private int aP0_PV_NPRO ;
      private String aP1_Gx_mode ;
      private String aP2_SISTEMA ;
      private String aP3_USUARIO ;
      private IDataStoreProvider pr_default ;
      private int[] T00184_A28PV_NPRO ;
      private String[] T00184_A5PV_DESC ;
      private int[] T00185_A28PV_NPRO ;
      private int[] T00183_A28PV_NPRO ;
      private String[] T00183_A5PV_DESC ;
      private int[] T00186_A28PV_NPRO ;
      private int[] T00187_A28PV_NPRO ;
      private int[] T00188_A28PV_NPRO ;
      private String[] T00188_A5PV_DESC ;
      private int[] T001812_A11TTBUS_Id ;
      private int[] T001813_A28PV_NPRO ;
      private int[] T00182_A28PV_NPRO ;
      private String[] T00182_A5PV_DESC ;
      private GXWebForm Form ;
   }

   public class tm124fprov__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00182 ;
          prmT00182 = new Object[] {
          new Object[] {"@PV_NPRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00184 ;
          prmT00184 = new Object[] {
          new Object[] {"@PV_NPRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00185 ;
          prmT00185 = new Object[] {
          new Object[] {"@PV_NPRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00183 ;
          prmT00183 = new Object[] {
          new Object[] {"@PV_NPRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00186 ;
          prmT00186 = new Object[] {
          new Object[] {"@PV_NPRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00187 ;
          prmT00187 = new Object[] {
          new Object[] {"@PV_NPRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00188 ;
          prmT00188 = new Object[] {
          new Object[] {"@PV_NPRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00189 ;
          prmT00189 = new Object[] {
          new Object[] {"@PV_NPRO",SqlDbType.Int,8,0} ,
          new Object[] {"@PV_DESC",SqlDbType.Char,30,0}
          } ;
          Object[] prmT001810 ;
          prmT001810 = new Object[] {
          new Object[] {"@PV_DESC",SqlDbType.Char,30,0} ,
          new Object[] {"@PV_NPRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmT001811 ;
          prmT001811 = new Object[] {
          new Object[] {"@PV_NPRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmT001812 ;
          prmT001812 = new Object[] {
          new Object[] {"@PV_NPRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmT001813 ;
          prmT001813 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00182", "SELECT [PV_NPRO], [PV_DESC] FROM [M124FPROV] WITH (UPDLOCK) WHERE [PV_NPRO] = @PV_NPRO ",true, GxErrorMask.GX_NOMASK, false, this,prmT00182,1,0,true,false )
             ,new CursorDef("T00183", "SELECT [PV_NPRO], [PV_DESC] FROM [M124FPROV] WITH (NOLOCK) WHERE [PV_NPRO] = @PV_NPRO ",true, GxErrorMask.GX_NOMASK, false, this,prmT00183,1,0,true,false )
             ,new CursorDef("T00184", "SELECT TM1.[PV_NPRO], TM1.[PV_DESC] FROM [M124FPROV] TM1 WITH (NOLOCK) WHERE TM1.[PV_NPRO] = @PV_NPRO ORDER BY TM1.[PV_NPRO]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00184,100,0,true,false )
             ,new CursorDef("T00185", "SELECT [PV_NPRO] FROM [M124FPROV] WITH (NOLOCK) WHERE [PV_NPRO] = @PV_NPRO  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00185,1,0,true,false )
             ,new CursorDef("T00186", "SELECT TOP 1 [PV_NPRO] FROM [M124FPROV] WITH (NOLOCK) WHERE ( [PV_NPRO] > @PV_NPRO) ORDER BY [PV_NPRO]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00186,1,0,true,true )
             ,new CursorDef("T00187", "SELECT TOP 1 [PV_NPRO] FROM [M124FPROV] WITH (NOLOCK) WHERE ( [PV_NPRO] < @PV_NPRO) ORDER BY [PV_NPRO] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00187,1,0,true,true )
             ,new CursorDef("T00188", "SELECT [PV_NPRO], [PV_DESC] FROM [M124FPROV] WITH (UPDLOCK) WHERE [PV_NPRO] = @PV_NPRO ",true, GxErrorMask.GX_NOMASK, false, this,prmT00188,1,0,true,false )
             ,new CursorDef("T00189", "INSERT INTO [M124FPROV] ([PV_NPRO], [PV_DESC]) VALUES (@PV_NPRO, @PV_DESC)", GxErrorMask.GX_NOMASK,prmT00189)
             ,new CursorDef("T001810", "UPDATE [M124FPROV] SET [PV_DESC]=@PV_DESC  WHERE [PV_NPRO] = @PV_NPRO", GxErrorMask.GX_NOMASK,prmT001810)
             ,new CursorDef("T001811", "DELETE FROM [M124FPROV]  WHERE [PV_NPRO] = @PV_NPRO", GxErrorMask.GX_NOMASK,prmT001811)
             ,new CursorDef("T001812", "SELECT TOP 1 [TTBUS_Id] FROM [TTBUS000] WITH (NOLOCK) WHERE [TTBUS_CodProveedor] = @PV_NPRO ",true, GxErrorMask.GX_NOMASK, false, this,prmT001812,1,0,true,true )
             ,new CursorDef("T001813", "SELECT [PV_NPRO] FROM [M124FPROV] WITH (NOLOCK) ORDER BY [PV_NPRO]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001813,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 6 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                break;
             case 10 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 11 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 9 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 10 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
