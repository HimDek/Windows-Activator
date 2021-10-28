#include <windows.h>
#pragma once

namespace WindowsActivator {
	using namespace std;
	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	public ref class Form_Activate : public System::Windows::Forms::Form
	{
	public:
		Form_Activate(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~Form_Activate()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Label^ label_Windows;
	private: System::Windows::Forms::ComboBox^ comboBox_Windows;
	private: System::Windows::Forms::ComboBox^ comboBox_Edition;
	private: System::ComponentModel::BackgroundWorker^ backgroundWorker_Activate;



	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(Form_Activate::typeid));
			this->label_Windows = (gcnew System::Windows::Forms::Label());
			this->comboBox_Windows = (gcnew System::Windows::Forms::ComboBox());
			this->comboBox_Edition = (gcnew System::Windows::Forms::ComboBox());
			this->backgroundWorker_Activate = (gcnew System::ComponentModel::BackgroundWorker());
			this->SuspendLayout();
			// 
			// label_Windows
			// 
			this->label_Windows->BackColor = System::Drawing::SystemColors::Window;
			this->label_Windows->Cursor = System::Windows::Forms::Cursors::IBeam;
			this->label_Windows->Location = System::Drawing::Point(9, 12);
			this->label_Windows->Margin = System::Windows::Forms::Padding(0);
			this->label_Windows->Name = L"label_Windows";
			this->label_Windows->Size = System::Drawing::Size(51, 13);
			this->label_Windows->TabIndex = 0;
			this->label_Windows->Text = L"Windows";
			this->label_Windows->TextAlign = System::Drawing::ContentAlignment::MiddleCenter;
			// 
			// comboBox_Windows
			// 
			this->comboBox_Windows->Cursor = System::Windows::Forms::Cursors::Hand;
			this->comboBox_Windows->DropDownStyle = System::Windows::Forms::ComboBoxStyle::DropDownList;
			this->comboBox_Windows->FormattingEnabled = true;
			this->comboBox_Windows->Items->AddRange(gcnew cli::array< System::Object^  >(4) { L"8", L"8.1", L"10", L"11" });
			this->comboBox_Windows->Location = System::Drawing::Point(60, 9);
			this->comboBox_Windows->Margin = System::Windows::Forms::Padding(0, 0, 1, 0);
			this->comboBox_Windows->Name = L"comboBox_Windows";
			this->comboBox_Windows->Size = System::Drawing::Size(40, 21);
			this->comboBox_Windows->TabIndex = 1;
			this->comboBox_Windows->SelectedIndexChanged += gcnew System::EventHandler(this, &Form_Activate::comboBox_Windows_SelectedIndexChanged);
			// 
			// comboBox_Edition
			// 
			this->comboBox_Edition->Cursor = System::Windows::Forms::Cursors::Hand;
			this->comboBox_Edition->DropDownStyle = System::Windows::Forms::ComboBoxStyle::DropDownList;
			this->comboBox_Edition->Enabled = false;
			this->comboBox_Edition->FormattingEnabled = true;
			this->comboBox_Edition->Location = System::Drawing::Point(104, 9);
			this->comboBox_Edition->Margin = System::Windows::Forms::Padding(0, 0, 1, 0);
			this->comboBox_Edition->Name = L"comboBox_Edition";
			this->comboBox_Edition->Size = System::Drawing::Size(140, 21);
			this->comboBox_Edition->TabIndex = 2;
			this->comboBox_Edition->Visible = false;
			this->comboBox_Edition->SelectedIndexChanged += gcnew System::EventHandler(this, &Form_Activate::comboBox_Edition_SelectedIndexChanged);
			// 
			// backgroundWorker_Activate
			// 
			this->backgroundWorker_Activate->WorkerReportsProgress = true;
			this->backgroundWorker_Activate->DoWork += gcnew System::ComponentModel::DoWorkEventHandler(this, &Form_Activate::backgroundWorker_Activate_DoWork);
			this->backgroundWorker_Activate->ProgressChanged += gcnew System::ComponentModel::ProgressChangedEventHandler(this, &Form_Activate::backgroundWorker_Activate_ProgressChanged);
			this->backgroundWorker_Activate->RunWorkerCompleted += gcnew System::ComponentModel::RunWorkerCompletedEventHandler(this, &Form_Activate::backgroundWorker_Activate_RunWorkerCompleted);
			// 
			// Form_Activate
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::Window;
			this->ClientSize = System::Drawing::Size(110, 39);
			this->Controls->Add(this->comboBox_Edition);
			this->Controls->Add(this->comboBox_Windows);
			this->Controls->Add(this->label_Windows);
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::FixedToolWindow;
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->MaximizeBox = false;
			this->Name = L"Form_Activate";
			this->StartPosition = System::Windows::Forms::FormStartPosition::CenterScreen;
			this->Text = L"Activate";
			this->FormClosed += gcnew System::Windows::Forms::FormClosedEventHandler(this, &Form_Activate::Form_Activate_FormClosed);
			this->Load += gcnew System::EventHandler(this, &Form_Activate::Form_Activate_Load);
			this->ResumeLayout(false);
		}
#pragma endregion
		private: System::Void Form_Activate_Load(System::Object^ sender, System::EventArgs^ e) {
		}
		private: System::Void Form_Activate_FormClosed(System::Object^ sender, System::Windows::Forms::FormClosedEventArgs^ e) {
			exit(0);
		}
		private: System::Void comboBox_Windows_SelectedIndexChanged(System::Object^ sender, System::EventArgs^ e) {
			if (comboBox_Windows->Text == "8") {
				comboBox_Edition->Items->Clear();
				comboBox_Edition->Items->AddRange(gcnew cli::array< System::Object^  >(7) { L"Home", L"Home Single Language", L"Professional", L"Professional N", L"Professional WMC", L"Enterprice", L"Enterprice N" });
			}
			else if (comboBox_Windows->Text == "8.1") {
				comboBox_Edition->Items->Clear();
				comboBox_Edition->Items->AddRange(gcnew cli::array< System::Object^  >(8) { L"Home", L"Home N", L"Home Single Language", L"Professional", L"Professional N", L"Professional WMC", L"Enterprice", L"Enterprice N" });
			}
			else if (comboBox_Windows->Text == "10") {
				comboBox_Edition->Items->Clear();
				comboBox_Edition->Items->AddRange(gcnew cli::array< System::Object^  >(10) { L"Home", L"Home N", L"Home Single Language", L"Home Country Specific", L"Professional", L"Professional N", L"Education", L"Education N", L"Enterprice", L"Enterprice N" });
			}
			else if (comboBox_Windows->Text == "11") {
				comboBox_Edition->Items->Clear();
				comboBox_Edition->Items->AddRange(gcnew cli::array< System::Object^  >(10) { L"Home", L"Home N", L"Home Single Language", L"Home Country Specific", L"Professional", L"Professional N", L"Education", L"Education N", L"Enterprice", L"Enterprice N" });
			}
			if (this->ClientSize == System::Drawing::Size(110, 39)) {
				for (int i = 18; i < 145; i = i + 18) {
					this->ClientSize = System::Drawing::Size(110 + i, 39);
					int x = this->Left;
					int y = this->Top;
					this->Location = System::Drawing::Point(x - 9, y);
					Sleep(20);
				}
			}
			comboBox_Edition->Visible = true;
			comboBox_Edition->Enabled = true;
		}
		private: System::Void comboBox_Edition_SelectedIndexChanged(System::Object^ sender, System::EventArgs^ e) {
			label_Windows->Visible = false;
			comboBox_Windows->Visible = false;
			comboBox_Edition->Visible = false;
			label_Windows->Dock = System::Windows::Forms::DockStyle::Fill;
			System::Tuple<System::String^, System::String^>^ arguments = gcnew System::Tuple<System::String^, System::String^>(comboBox_Windows->Text, comboBox_Edition->Text);
			backgroundWorker_Activate->RunWorkerAsync(arguments);
		}
		private: System::Void backgroundWorker_Activate_DoWork(System::Object^ sender, System::ComponentModel::DoWorkEventArgs^ e) {
			System::Tuple<System::String^, System::String^>^ arglist = safe_cast<System::Tuple<System::String^, System::String^>^>(e->Argument);
			System::String^ Windows = arglist->Item1;
			System::String^ Edition = arglist->Item2;
			backgroundWorker_Activate->ReportProgress(1);
			InstallKey(GenerateKeyCommand(Windows, Edition));
			backgroundWorker_Activate->ReportProgress(2);
			KMS();
			backgroundWorker_Activate->ReportProgress(3);
			FinalActivate(Windows, Edition);
		}
		private: System::Void backgroundWorker_Activate_ProgressChanged(System::Object^ sender, System::ComponentModel::ProgressChangedEventArgs^ e) {
			if (e->ProgressPercentage == 1) {
				label_Windows->Text = "Installing Product Key!";
				label_Windows->Visible = true;
			}
			else if (e->ProgressPercentage == 2) {
				label_Windows->Text = "Setting Key Management Service!";
			}
			else if (e->ProgressPercentage == 3) {
				label_Windows->Text = "Activating Windows " + comboBox_Windows->Text + " " + comboBox_Edition->Text + "!";
			}
			label_Windows->Update();
		}
		private: System::Void backgroundWorker_Activate_RunWorkerCompleted(System::Object^ sender, System::ComponentModel::RunWorkerCompletedEventArgs^ e) {
			exit(0);
		}
		private: System::Void InstallKey(wchar_t * CMDLine) {
			cmd(CMDLine);
		}
		private: System::Void KMS() {
			cmd(L"/c slmgr /skms kms8.msguides.com");
		}
		private: System::Void FinalActivate(System::String^ Windows, System::String^ Edition) {
			cmd(L"/c slmgr /ato");
		}
		private: wchar_t * GenerateKeyCommand(System::String^ Windows, System::String^ Edition) {
			if (Windows == "8") {
			    if (Edition == "Home") {
					return L"/c slmgr /ipk BN3D2-R7TKB-3YPBD-8DRP2-27GG4";
			    }
			    if (Edition == "Home Single Language") {
			        return L"/c slmgr /ipk 2WN2H-YGCQR-KFX6K-CD6TF-84YXQ";
			    }
			    if (Edition == "Professional") {
			        return L"/c slmgr /ipk NG4HW-VH26C-733KW-K6F98-J8CK4";
			    }
			    if (Edition == "Professional N") {
			        return L"/c slmgr /ipk XCVCF-2NXM9-723PB-MHCB7-2RYQQ";
			    }
			    if (Edition == "Professional WMC") {
			        return L"/c slmgr /ipk GNBB8-YVD74-QJHX6-27H4K-8QHDG";
			    }
			    if (Edition == "Enterprice") {
			        return L"/c slmgr /ipk 32JNW-9KQ84-P47T8-D8GGY-CWCK7";
			    }
			    if (Edition == "Enterprice N") {
			        return L"/c slmgr /ipk JMNMF-RHW7P-DMY6X-RF3DR-X2BQT";
			    }
			}
			if (Windows == "8.1") {
			    if (Edition == "Home") {
			        return L"/c slmgr /ipk M9Q9P-WNJJT-6PXPY-DWX8H-6XWKK";
			    }
			    if (Edition == "Home N") {
			        return L"/c slmgr /ipk 7B9N3-D94CG-YTVHR-QBPX3-RJP64";
			    }
			    if (Edition == "Home Single Language") {
			        return L"/c slmgr /ipk BB6NG-PQ82V-VRDPW-8XVD2-V8P66";
			    }
			    if (Edition == "Professional") {
			        return L"/c slmgr /ipk GCRJD-8NW9H-F2CDX-CCM8D-9D6T9";
			    }
			    if (Edition == "Professional N") {
			        return L"/c slmgr /ipk HMCNV-VVBFX-7HMBH-CTY9B-B4FXY";
			    }
			    if (Edition == "Professional WMC") {
			        return L"/c slmgr /ipk 789NJ-TQK6T-6XTH8-J39CJ-J8D3P";
			    }
			    if (Edition == "Enterprice") {
			        return L"/c slmgr /ipk MHF9N-XY6XB-WVXMC-BTDCT-MKKG7";
			    }
			    if (Edition == "Enterprice N") {
			        return L"/c slmgr /ipk TT4HM-HN7YT-62K67-RGRQJ-JFFXW";
			    }
			} 
			if (Windows == "10") {
			    if (Edition == "Home") {
			        return L"/c slmgr /ipk TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
			    }
			    if (Edition == "Home N") {
			        return L"/c slmgr /ipk 3KHY7-WNT83-DGQKR-F7HPR-844BM";
			    }
			    if (Edition == "Home Single Language") {
			        return L"/c slmgr /ipk 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH";
			    }
			    if (Edition == "Home Country Specific") {
			        return L"/c slmgr /ipk PVMJN-6DFY6-9CCP6-7BKTT-D3WVR";
			    }
			    if (Edition == "Professional") {
			        return L"/c slmgr /ipk W269N-WFGWX-YVC9B-4J6C9-T83GX";
			    }
			    if (Edition == "Professional N") {
			        return L"/c slmgr /ipk MH37W-N47XK-V7XM9-C7227-GCQG9";
			    }
			    if (Edition == "Education") {
			        return L"/c slmgr /ipk NW6C2-QMPVW-D7KKK-3GKT6-VCFB2";
			    }
			    if (Edition == "Education N") {
			        return L"/c slmgr /ipk 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ";
			    }
			    if (Edition == "Enterprice") {
			        return L"/c slmgr /ipk NPPR9-FWDCX-D2C8J-H872K-2YT43";
			    }
			    if (Edition == "Enterprice N") {
			        return L"/c slmgr /ipk DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4";
			    }
			}
			if (Windows == "11")
			{
				if (Edition == "Home") {
					return L"/c slmgr /ipk TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
				}
				if (Edition == "Home N") {
					return L"/c slmgr /ipk 3KHY7-WNT83-DGQKR-F7HPR-844BM";
				}
				if (Edition == "Home Single Language") {
					return L"/c slmgr /ipk 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH";
				}
				if (Edition == "Home Country Specific") {
					return L"/c slmgr /ipk PVMJN-6DFY6-9CCP6-7BKTT-D3WVR";
				}
				if (Edition == "Professional") {
					return L"/c slmgr /ipk W269N-WFGWX-YVC9B-4J6C9-T83GX";
				}
				if (Edition == "Professional N") {
					return L"/c slmgr /ipk MH37W-N47XK-V7XM9-C7227-GCQG9";
				}
				if (Edition == "Education") {
					return L"/c slmgr /ipk NW6C2-QMPVW-D7KKK-3GKT6-VCFB2";
				}
				if (Edition == "Education N") {
					return L"/c slmgr /ipk 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ";
				}
				if (Edition == "Enterprice") {
					return L"/c slmgr /ipk NPPR9-FWDCX-D2C8J-H872K-2YT43";
				}
				if (Edition == "Enterprice N") {
					return L"/c slmgr /ipk DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4";
				}
			}
			return L"";
		}
		private: System::Void cmd(wchar_t * Command) {
			LPTSTR CmdLine = Command;
			STARTUPINFO si;
			PROCESS_INFORMATION pi;

			ZeroMemory(&si, sizeof(si));
			si.cb = sizeof(si);
			ZeroMemory(&pi, sizeof(pi));

			if (CreateProcess(L"C:\\Windows\\System32\\cmd.exe", CmdLine, NULL, NULL, FALSE, CREATE_NO_WINDOW, NULL, NULL, &si, &pi))
			{
				WaitForSingleObject(pi.hProcess, INFINITE);
				CloseHandle(pi.hProcess);
				CloseHandle(pi.hThread);
			}
		}
	};
}