using Newtonsoft.Json;
using System.Collections.Generic;
using HplEdgeClient.Enums;
using HplEdgeClient.Inputs;

namespace HplEdgeClient.Params
{
  public class FindCompressedAccountsParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses;

    [JsonProperty("identity")]
    public DisrcriminatorFilter Identity;

    [JsonProperty("leaves")]
    public List<TreeLeaf> Leaves;

    [JsonProperty("parsedData")]
    public object ParsedData;

    public FindCompressedAccountsParams() { }

  }

  public class FetchProofsParams
  {
    [JsonProperty("leaves")]
    public List<TreeLeaf> Leaves;

    public FetchProofsParams() { }

  }

  public class FindAccountsParams
  {
    [JsonProperty("programId")]
    public string ProgramId;

    [JsonProperty("discriminator")]
    public string Discriminator;

    [JsonProperty("parsedData")]
    public object ParsedData;

    public FindAccountsParams() { }

  }

  public class SendTransactionBundlesParams
  {
    [JsonProperty("txs")]
    public List<string> Txs;

    [JsonProperty("blockhash")]
    public string Blockhash;

    [JsonProperty("lastValidBlockHeight")]
    public int LastValidBlockHeight;

    [JsonProperty("options")]
    public SendTransactionBundlesOptions Options;

    public SendTransactionBundlesParams() { }

  }

  public class SignWithShadowSignerAndSendTransactionBundlesParams
  {
    [JsonProperty("txs")]
    public List<string> Txs;

    [JsonProperty("blockhash")]
    public string Blockhash;

    [JsonProperty("lastValidBlockHeight")]
    public int LastValidBlockHeight;

    [JsonProperty("authToken")]
    public string AuthToken;

    [JsonProperty("options")]
    public SendTransactionBundlesOptions Options;

    public SignWithShadowSignerAndSendTransactionBundlesParams() { }

  }

  public class SendBulkTransactionsParams
  {
    [JsonProperty("txs")]
    public List<string> Txs;

    [JsonProperty("blockhash")]
    public string Blockhash;

    [JsonProperty("lastValidBlockHeight")]
    public int LastValidBlockHeight;

    [JsonProperty("options")]
    public SendTransactionBundlesOptions Options;

    public SendBulkTransactionsParams() { }

  }

  public class SignWithShadowSignerAndSendBulkTransactionsParams
  {
    [JsonProperty("txs")]
    public List<string> Txs;

    [JsonProperty("blockhash")]
    public string Blockhash;

    [JsonProperty("lastValidBlockHeight")]
    public int LastValidBlockHeight;

    [JsonProperty("options")]
    public SendTransactionBundlesOptions Options;

    public SignWithShadowSignerAndSendBulkTransactionsParams() { }

  }

  public class AuthRequestParams
  {
    [JsonProperty("wallet")]
    public string Wallet;

    [JsonProperty("useTx")]
    public bool UseTx;

    [JsonProperty("useRpc")]
    public string UseRpc;

    public AuthRequestParams() { }

  }

  public class AuthConfirmParams
  {
    [JsonProperty("wallet")]
    public string Wallet;

    [JsonProperty("signature")]
    public string Signature;

    public AuthConfirmParams() { }

  }

  public class FindGlobalParams
  {
    [JsonProperty("env")]
    public string Env;

    public FindGlobalParams() { }

  }

  public class FindProjectsParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses;

    [JsonProperty("names")]
    public List<string> Names;

    [JsonProperty("authorities")]
    public List<string> Authorities;

    public FindProjectsParams() { }

  }

  public class FindDelegateAuthorityParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses;

    [JsonProperty("delegates")]
    public List<string> Delegates;

    [JsonProperty("projects")]
    public List<string> Projects;

    public FindDelegateAuthorityParams() { }

  }

  public class FindUsersParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses;

    [JsonProperty("ids")]
    public List<int> Ids;

    [JsonProperty("wallets")]
    public List<string> Wallets;

    [JsonProperty("includeProof")]
    public bool IncludeProof;

    [JsonProperty("includeProjectProfiles")]
    public List<string> IncludeProjectProfiles;

    public FindUsersParams() { }

  }

  public class FindProfilesParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses;

    [JsonProperty("projects")]
    public List<string> Projects;

    [JsonProperty("userIds")]
    public List<int> UserIds;

    [JsonProperty("identities")]
    public List<string> Identities;

    [JsonProperty("includeProof")]
    public bool IncludeProof;

    [JsonProperty("includeUsers")]
    public bool IncludeUsers;

    public FindProfilesParams() { }

  }

  public class CreateNewUserTransactionParams
  {
    [JsonProperty("wallet")]
    public string Wallet;

    [JsonProperty("info")]
    public UserInfoInput Info;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateNewUserTransactionParams() { }

  }

  public class CreateNewUserBulkTransactionParams
  {
    [JsonProperty("wallet")]
    public List<string> Wallet;

    [JsonProperty("info")]
    public List<UserInfoInput> Info;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateNewUserBulkTransactionParams() { }

  }

  public class CreateUpdateUserTransactionParams
  {
    [JsonProperty("info")]
    public PartialUserInfoInput Info;

    [JsonProperty("wallets")]
    public UpdateWalletInput Wallets;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("populateCivic")]
    public bool PopulateCivic;

    [JsonProperty("removeSocials")]
    public List<RemoveSocialsInput> RemoveSocials;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateUpdateUserTransactionParams() { }

  }

  public class CreateCreateProjectTransactionParams
  {
    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("name")]
    public string Name;

    [JsonProperty("driver")]
    public string Driver;

    [JsonProperty("associatedPrograms")]
    public List<AssociatedProgramInput> AssociatedPrograms;

    [JsonProperty("profileDataConfig")]
    public ProfileDataConfigInput ProfileDataConfig;

    [JsonProperty("subsidizeFees")]
    public bool SubsidizeFees;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateCreateProjectTransactionParams() { }

  }

  public class CreateChangeProjectDriverTransactionParams
  {
    [JsonProperty("project")]
    public string Project;

    [JsonProperty("driver")]
    public string Driver;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateChangeProjectDriverTransactionParams() { }

  }

  public class CreateCreateDelegateAuthorityTransactionParams
  {
    [JsonProperty("project")]
    public string Project;

    [JsonProperty("delegate")]
    public string Delegate;

    [JsonProperty("serviceDelegations")]
    public ServiceDelegationInput ServiceDelegations;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateCreateDelegateAuthorityTransactionParams() { }

  }

  public class CreateModifyDelegationTransactionParams
  {
    [JsonProperty("project")]
    public string Project;

    [JsonProperty("delegate")]
    public string Delegate;

    [JsonProperty("modifyDelegation")]
    public ModifyDelegationInput ModifyDelegation;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateModifyDelegationTransactionParams() { }

  }

  public class CreateCreateProfilesTreeTransactionParams
  {
    [JsonProperty("treeConfig")]
    public TreeSetupConfig TreeConfig;

    [JsonProperty("project")]
    public string Project;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateCreateProfilesTreeTransactionParams() { }

  }

  public class CreateNewProfileTransactionParams
  {
    [JsonProperty("project")]
    public string Project;

    [JsonProperty("identity")]
    public string Identity;

    [JsonProperty("info")]
    public ProfileInfoInput Info;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateNewProfileTransactionParams() { }

  }

  public class CreateUpdateProfileTransactionParams
  {
    [JsonProperty("profile")]
    public string Profile;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("info")]
    public ProfileInfoInput Info;

    [JsonProperty("customData")]
    public CustomDataInput CustomData;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateUpdateProfileTransactionParams() { }

  }

  public class CreateNewUserWithProfileTransactionParams
  {
    [JsonProperty("project")]
    public string Project;

    [JsonProperty("wallet")]
    public string Wallet;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("userInfo")]
    public UserInfoInput UserInfo;

    [JsonProperty("profileIdentity")]
    public string ProfileIdentity;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateNewUserWithProfileTransactionParams() { }

  }

  public class FindAssemblerConfigParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses;

    [JsonProperty("tickers")]
    public List<string> Tickers;

    [JsonProperty("characterModel")]
    public List<string> CharacterModel;

    [JsonProperty("project")]
    public List<string> Project;

    public FindAssemblerConfigParams() { }

  }

  public class FindCharacterTraitsParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses;

    [JsonProperty("trees")]
    public List<string> Trees;

    [JsonProperty("includeProof")]
    public bool IncludeProof;

    public FindCharacterTraitsParams() { }

  }

  public class FindCharacterModelsParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses;

    [JsonProperty("project")]
    public string Project;

    [JsonProperty("assemblerConfigs")]
    public List<string> AssemblerConfigs;

    public FindCharacterModelsParams() { }

  }

  public class FindCharactersParams
  {
    [JsonProperty("includeProof")]
    public bool IncludeProof;

    [JsonProperty("addresses")]
    public List<string> Addresses;

    [JsonProperty("filters")]
    public CharactersFilter Filters;

    [JsonProperty("trees")]
    public List<string> Trees;

    [JsonProperty("wallets")]
    public List<string> Wallets;

    [JsonProperty("mints")]
    public List<string> Mints;

    [JsonProperty("attributeHashes")]
    public List<string> AttributeHashes;

    public FindCharactersParams() { }

  }

  public class FetchCharacterHistoryParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses;

    [JsonProperty("event")]
    public List<string> Event;

    public FetchCharacterHistoryParams() { }

  }

  public class CreateCreateAssemblerConfigTransactionParams
  {
    [JsonProperty("treeConfig")]
    public TreeSetupConfig TreeConfig;

    [JsonProperty("ticker")]
    public string Ticker;

    [JsonProperty("order")]
    public List<string> Order;

    [JsonProperty("project")]
    public string Project;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateCreateAssemblerConfigTransactionParams() { }

  }

  public class CreateAddCharacterTraitsTransactionsParams
  {
    [JsonProperty("assemblerConfig")]
    public string AssemblerConfig;

    [JsonProperty("traits")]
    public List<CharacterTraitInput> Traits;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateAddCharacterTraitsTransactionsParams() { }

  }

  public class CreateRemoveCharacterTraitsTransactionsParams
  {
    [JsonProperty("assemblerConfig")]
    public string AssemblerConfig;

    [JsonProperty("traitsAddresses")]
    public List<string> TraitsAddresses;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateRemoveCharacterTraitsTransactionsParams() { }

  }

  public class CreateCreateCharacterModelTransactionParams
  {
    [JsonProperty("config")]
    public CharacterConfigInput Config;

    [JsonProperty("project")]
    public string Project;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("attributes")]
    public object Attributes;

    [JsonProperty("mintAs")]
    public MintAsInput MintAs;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateCreateCharacterModelTransactionParams() { }

  }

  public class CreateCreateCharactersTreeTransactionParams
  {
    [JsonProperty("treeConfig")]
    public TreeSetupConfig TreeConfig;

    [JsonProperty("project")]
    public string Project;

    [JsonProperty("characterModel")]
    public string CharacterModel;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateCreateCharactersTreeTransactionParams() { }

  }

  public class CreateAssembleCharacterTransactionParams
  {
    [JsonProperty("attributes")]
    public object Attributes;

    [JsonProperty("project")]
    public string Project;

    [JsonProperty("assemblerConfig")]
    public string AssemblerConfig;

    [JsonProperty("characterModel")]
    public string CharacterModel;

    [JsonProperty("wallet")]
    public string Wallet;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateAssembleCharacterTransactionParams() { }

  }

  public class CreateUpdateCharacterTraitsTransactionParams
  {
    [JsonProperty("characterAddress")]
    public string CharacterAddress;

    [JsonProperty("attributes")]
    public object Attributes;

    [JsonProperty("project")]
    public string Project;

    [JsonProperty("assemblerConfig")]
    public string AssemblerConfig;

    [JsonProperty("characterModel")]
    public string CharacterModel;

    [JsonProperty("wallet")]
    public string Wallet;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateUpdateCharacterTraitsTransactionParams() { }

  }

  public class CreatePopulateCharacterTransactionParams
  {
    [JsonProperty("attributes")]
    public object Attributes;

    [JsonProperty("project")]
    public string Project;

    [JsonProperty("assemblerConfig")]
    public string AssemblerConfig;

    [JsonProperty("characterModel")]
    public string CharacterModel;

    [JsonProperty("mint")]
    public string Mint;

    [JsonProperty("owner")]
    public string Owner;

    [JsonProperty("updateAuthority")]
    public string UpdateAuthority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreatePopulateCharacterTransactionParams() { }

  }

  public class CreateWrapAssetsToCharacterTransactionsParams
  {
    [JsonProperty("project")]
    public string Project;

    [JsonProperty("characterModel")]
    public string CharacterModel;

    [JsonProperty("wallet")]
    public string Wallet;

    [JsonProperty("mintList")]
    public List<string> MintList;

    [JsonProperty("libreplexDeployment")]
    public string LibreplexDeployment;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateWrapAssetsToCharacterTransactionsParams() { }

  }

  public class CreateUnwrapAssetsFromCharacterTransactionsParams
  {
    [JsonProperty("project")]
    public string Project;

    [JsonProperty("characterAddresses")]
    public List<string> CharacterAddresses;

    [JsonProperty("characterModel")]
    public string CharacterModel;

    [JsonProperty("wallet")]
    public string Wallet;

    [JsonProperty("libreplexDeployment")]
    public string LibreplexDeployment;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateUnwrapAssetsFromCharacterTransactionsParams() { }

  }

  public class FindStakingPoolsParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses;

    [JsonProperty("projects")]
    public List<string> Projects;

    [JsonProperty("names")]
    public List<string> Names;

    public FindStakingPoolsParams() { }

  }

  public class FindStakersParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses;

    [JsonProperty("stakingPools")]
    public List<string> StakingPools;

    [JsonProperty("wallets")]
    public List<string> Wallets;

    public FindStakersParams() { }

  }

  public class FindMultipliersParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses;

    [JsonProperty("stakingPools")]
    public List<string> StakingPools;

    public FindMultipliersParams() { }

  }

  public class CreateCreateStakingPoolTransactionParams
  {
    [JsonProperty("project")]
    public string Project;

    [JsonProperty("resource")]
    public string Resource;

    [JsonProperty("metadata")]
    public CreateStakingPoolMetadataInput Metadata;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("multiplier")]
    public InitStakingMultiplierMetadataInput Multiplier;

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateCreateStakingPoolTransactionParams() { }

  }

  public class CreateUpdateStakingPoolTransactionParams
  {
    [JsonProperty("project")]
    public string Project;

    [JsonProperty("stakingPool")]
    public string StakingPool;

    [JsonProperty("metadata")]
    public UpdateStakingPoolMetadataInput Metadata;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("characterModel")]
    public string CharacterModel;

    [JsonProperty("resource")]
    public string Resource;

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateUpdateStakingPoolTransactionParams() { }

  }

  public class CreateInitMultipliersTransactionParams
  {
    [JsonProperty("project")]
    public string Project;

    [JsonProperty("stakingPool")]
    public string StakingPool;

    [JsonProperty("decimals")]
    public int Decimals;

    [JsonProperty("multipliers")]
    public List<AddMultiplierMetadataInput> Multipliers;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateInitMultipliersTransactionParams() { }

  }

  public class CreateAddMultiplierTransactionParams
  {
    [JsonProperty("project")]
    public string Project;

    [JsonProperty("multiplier")]
    public string Multiplier;

    [JsonProperty("metadata")]
    public AddMultiplierMetadataInput Metadata;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateAddMultiplierTransactionParams() { }

  }

  public class CreateStakeCharactersTransactionsParams
  {
    [JsonProperty("characterAddresses")]
    public List<string> CharacterAddresses;

    [JsonProperty("characterModel")]
    public string CharacterModel;

    [JsonProperty("stakingPool")]
    public string StakingPool;

    [JsonProperty("project")]
    public string Project;

    [JsonProperty("feePayer")]
    public string FeePayer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateStakeCharactersTransactionsParams() { }

  }

  public class CreateClaimStakingRewardsTransactionsParams
  {
    [JsonProperty("characterAddresses")]
    public List<string> CharacterAddresses;

    [JsonProperty("characterModel")]
    public string CharacterModel;

    [JsonProperty("feePayer")]
    public string FeePayer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateClaimStakingRewardsTransactionsParams() { }

  }

  public class CreateUnstakeCharactersTransactionsParams
  {
    [JsonProperty("characterAddresses")]
    public List<string> CharacterAddresses;

    [JsonProperty("characterModel")]
    public string CharacterModel;

    [JsonProperty("feePayer")]
    public string FeePayer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateUnstakeCharactersTransactionsParams() { }

  }

  public class FindMissionsParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses;

    [JsonProperty("missionPools")]
    public List<string> MissionPools;

    public FindMissionsParams() { }

  }

  public class FindMissionPoolsParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses;

    [JsonProperty("project")]
    public string Project;

    public FindMissionPoolsParams() { }

  }

  public class CreateCreateMissionPoolTransactionParams
  {
    [JsonProperty("data")]
    public NewMissionPoolData Data;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateCreateMissionPoolTransactionParams() { }

  }

  public class CreateUpdateMissionPoolTransactionParams
  {
    [JsonProperty("data")]
    public UpdateMissionPoolData Data;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateUpdateMissionPoolTransactionParams() { }

  }

  public class CreateCreateMissionTransactionParams
  {
    [JsonProperty("data")]
    public NewMissionData Data;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateCreateMissionTransactionParams() { }

  }

  public class CreateUpdateMissionTransactionParams
  {
    [JsonProperty("missionAddress")]
    public string MissionAddress;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("params")]
    public UpdateMissionInput Params;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateUpdateMissionTransactionParams() { }

  }

  public class CreateSendCharactersOnMissionTransactionParams
  {
    [JsonProperty("data")]
    public ParticipateOnMissionData Data;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateSendCharactersOnMissionTransactionParams() { }

  }

  public class CreateRecallCharactersTransactionParams
  {
    [JsonProperty("data")]
    public RecallFromMissionData Data;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateRecallCharactersTransactionParams() { }

  }

  public class FindResourcesParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses;

    [JsonProperty("projects")]
    public List<string> Projects;

    [JsonProperty("mints")]
    public List<string> Mints;

    public FindResourcesParams() { }

  }

  public class FindResourcesBalanceParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses;

    [JsonProperty("projects")]
    public List<string> Projects;

    [JsonProperty("mints")]
    public List<string> Mints;

    [JsonProperty("wallets")]
    public List<string> Wallets;

    public FindResourcesBalanceParams() { }

  }

  public class FindFaucetsParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses;

    [JsonProperty("projects")]
    public List<string> Projects;

    [JsonProperty("resources")]
    public List<string> Resources;

    public FindFaucetsParams() { }

  }

  public class FindRecipesParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses;

    [JsonProperty("projects")]
    public List<string> Projects;

    public FindRecipesParams() { }

  }

  public class FindHoldingsParams
  {
    [JsonProperty("addresses")]
    public List<string> Addresses;

    [JsonProperty("holders")]
    public List<string> Holders;

    [JsonProperty("trees")]
    public List<string> Trees;

    [JsonProperty("includeProof")]
    public bool IncludeProof;

    public FindHoldingsParams() { }

  }

  public class CreateCreateNewResourceTransactionParams
  {
    [JsonProperty("project")]
    public string Project;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("params")]
    public InitResourceInput Params;

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateCreateNewResourceTransactionParams() { }

  }

  public class CreateImportFungibleResourceTransactionParams
  {
    [JsonProperty("params")]
    public ImportResourceInput Params;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateImportFungibleResourceTransactionParams() { }

  }

  public class CreateExportFungibleResourceTransactionParams
  {
    [JsonProperty("resource")]
    public string Resource;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateExportFungibleResourceTransactionParams() { }

  }

  public class CreateCreateNewResourceTreeTransactionParams
  {
    [JsonProperty("project")]
    public string Project;

    [JsonProperty("resource")]
    public string Resource;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("treeConfig")]
    public TreeSetupConfig TreeConfig;

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateCreateNewResourceTreeTransactionParams() { }

  }

  public class CreateMintResourceTransactionParams
  {
    [JsonProperty("resource")]
    public string Resource;

    [JsonProperty("owner")]
    public string Owner;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("amount")]
    public string Amount;

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateMintResourceTransactionParams() { }

  }

  public class CreateBurnResourceTransactionParams
  {
    [JsonProperty("resource")]
    public string Resource;

    [JsonProperty("amount")]
    public string Amount;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("owner")]
    public string Owner;

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateBurnResourceTransactionParams() { }

  }

  public class CreateTransferResourceTransactionParams
  {
    [JsonProperty("resource")]
    public string Resource;

    [JsonProperty("owner")]
    public string Owner;

    [JsonProperty("recipient")]
    public string Recipient;

    [JsonProperty("amount")]
    public string Amount;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateTransferResourceTransactionParams() { }

  }

  public class CreateCreateWrapHoldingTransactionParams
  {
    [JsonProperty("resource")]
    public string Resource;

    [JsonProperty("amount")]
    public string Amount;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateCreateWrapHoldingTransactionParams() { }

  }

  public class CreateCreateUnwrapHoldingTransactionParams
  {
    [JsonProperty("resource")]
    public string Resource;

    [JsonProperty("amount")]
    public string Amount;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateCreateUnwrapHoldingTransactionParams() { }

  }

  public class CreateInitializeRecipeTransactionParams
  {
    [JsonProperty("project")]
    public string Project;

    [JsonProperty("xp")]
    public string Xp;

    [JsonProperty("ingredients")]
    public List<IngredientsInput> Ingredients;

    [JsonProperty("meal")]
    public MealInput Meal;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateInitializeRecipeTransactionParams() { }

  }

  public class CreateAddIngredientsTransactionParams
  {
    [JsonProperty("recipe")]
    public string Recipe;

    [JsonProperty("ingredients")]
    public List<IngredientsInput> Ingredients;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateAddIngredientsTransactionParams() { }

  }

  public class CreateRemoveIngredientsTransactionParams
  {
    [JsonProperty("recipe")]
    public string Recipe;

    [JsonProperty("ingredients")]
    public List<string> Ingredients;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateRemoveIngredientsTransactionParams() { }

  }

  public class CreateInitializeFaucetTransactionParams
  {
    [JsonProperty("resource")]
    public string Resource;

    [JsonProperty("amount")]
    public int Amount;

    [JsonProperty("repeatInterval")]
    public int RepeatInterval;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("delegateAuthority")]
    public string DelegateAuthority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateInitializeFaucetTransactionParams() { }

  }

  public class CreateClaimFaucetTransactionParams
  {
    [JsonProperty("faucet")]
    public string Faucet;

    [JsonProperty("owner")]
    public string Owner;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateClaimFaucetTransactionParams() { }

  }

  public class CreateInitCookingProcessTransactionsParams
  {
    [JsonProperty("recipe")]
    public string Recipe;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("payer")]
    public string Payer;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    public CreateInitCookingProcessTransactionsParams() { }

  }

  public class CreateInitializeBadgeCriteriaTransactionParams
  {
    [JsonProperty("args")]
    public CreateBadgeCriteriaInput Args;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateInitializeBadgeCriteriaTransactionParams() { }

  }

  public class CreateClaimBadgeCriteriaTransactionParams
  {
    [JsonProperty("args")]
    public ClaimBadgeCriteriaInput Args;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateClaimBadgeCriteriaTransactionParams() { }

  }

  public class CreateUpdateBadgeCriteriaTransactionParams
  {
    [JsonProperty("args")]
    public UpdateBadgeCriteriaInput Args;

    [JsonProperty("lutAddresses")]
    public List<string> LutAddresses;

    [JsonProperty("computeUnitPrice")]
    public int ComputeUnitPrice;

    public CreateUpdateBadgeCriteriaTransactionParams() { }

  }

}

