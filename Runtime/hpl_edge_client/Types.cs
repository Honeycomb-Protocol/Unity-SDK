using Newtonsoft.Json;
using System.Collections.Generic;

using HplEdgeClient.Enums;

namespace HplEdgeClient.Types
{
  public class CharacterConfig
  {
    [JsonProperty("kind")]
    public string Kind;

    [JsonProperty("criterias")]
    public List<AssetCriteria> Criterias;

    [JsonProperty("assemblerConfig")]
    public string AssemblerConfig;

    [JsonProperty("name")]
    public string Name;

    [JsonProperty("symbol")]
    public string Symbol;

    [JsonProperty("description")]
    public string Description;

    [JsonProperty("creators")]
    public List<NftCreator> Creators;

    [JsonProperty("sellerFeeBasisPoints")]
    public int SellerFeeBasisPoints;

    [JsonProperty("collectionName")]
    public string CollectionName;

    [JsonProperty("mintAs")]
    public MintAs MintAs;

    public CharacterConfig() { }

  }

  public class MintAsParams
  {
    [JsonProperty("merkleTree")]
    public string MerkleTree;

    public MintAsParams() { }

  }

  public class CharacterSourceParams
  {
    [JsonProperty("mint")]
    public string Mint;

    [JsonProperty("criteria")]
    public AssetCriteria Criteria;

    [JsonProperty("kind")]
    public SourceKind Kind;

    [JsonProperty("hash")]
    public string Hash;

    [JsonProperty("uri")]
    public string Uri;

    [JsonProperty("attributes")]
    public object Attributes;

    [JsonProperty("assemblerConfig")]
    public string AssemblerConfig;

    public CharacterSourceParams() { }

  }

  public class CharacterUsedByParams
  {
    [JsonProperty("pool")]
    public string Pool;

    [JsonProperty("staker")]
    public string Staker;

    [JsonProperty("stakedAt")]
    public int StakedAt;

    [JsonProperty("claimedAt")]
    public int ClaimedAt;

    [JsonProperty("missionId")]
    public string MissionId;

    [JsonProperty("participationId")]
    public string ParticipationId;

    [JsonProperty("rewards")]
    public List<EarnedRewards> Rewards;

    [JsonProperty("endTime")]
    public int EndTime;

    [JsonProperty("id")]
    public string Id;

    [JsonProperty("role")]
    public GuildRole Role;

    [JsonProperty("order")]
    public int Order;

    [JsonProperty("mint")]
    public string Mint;

    [JsonProperty("user")]
    public string User;

    [JsonProperty("data")]
    public object Data;

    public CharacterUsedByParams() { }

  }

  public class ServiceParams
  {
    [JsonProperty("assemblerId")]
    public string AssemblerId;

    [JsonProperty("assetManagerId")]
    public string AssetManagerId;

    [JsonProperty("poolId")]
    public string PoolId;

    [JsonProperty("kitId")]
    public string KitId;

    public ServiceParams() { }

  }

  public class MissionRequirement
  {
    [JsonProperty("kind")]
    public string Kind;

    [JsonProperty("params")]
    public TimeRequirementParams Params;

    public MissionRequirement() { }

  }

  public class RewardType
  {
    [JsonProperty("kind")]
    public string Kind;

    [JsonProperty("params")]
    public ResourceRewardTypeParams Params;

    public RewardType() { }

  }

  public class MultiplierTypeParams
  {
    [JsonProperty("minDuration")]
    public string MinDuration;

    [JsonProperty("minCount")]
    public string MinCount;

    [JsonProperty("creator")]
    public string Creator;

    [JsonProperty("collection")]
    public string Collection;

    public MultiplierTypeParams() { }

  }

  public class OutputHolding
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("tree_id")]
    public string Tree_id;

    [JsonProperty("leaf_idx")]
    public string Leaf_idx;

    [JsonProperty("holder")]
    public string Holder;

    [JsonProperty("balance")]
    public string Balance;

    [JsonProperty("characteristics")]
    public object Characteristics;

    [JsonProperty("proof")]
    public Proof Proof;

    [JsonProperty("tree")]
    public string Tree;

    public OutputHolding() { }

  }

  public class ResourceKindParams
  {
    [JsonProperty("decimals")]
    public int Decimals;

    [JsonProperty("custody")]
    public ResourceCustody Custody;

    [JsonProperty("characteristics")]
    public List<string> Characteristics;

    public ResourceKindParams() { }

  }

  public class CharacterHistory
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("event")]
    public string Event;

    [JsonProperty("event_data")]
    public object Event_data;

    [JsonProperty("time")]
    public string Time;

    public CharacterHistory() { }

  }

  public class AssemblerConfig
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("program_id")]
    public string Program_id;

    [JsonProperty("discriminator")]
    public string Discriminator;

    [JsonProperty("ticker")]
    public string Ticker;

    [JsonProperty("project")]
    public string Project;

    [JsonProperty("order")]
    public List<string> Order;

    [JsonProperty("merkle_trees")]
    public ControlledMerkleTrees Merkle_trees;

    public AssemblerConfig() { }

  }

  public class CharacterTrait
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("tree_id")]
    public string Tree_id;

    [JsonProperty("leaf_idx")]
    public string Leaf_idx;

    [JsonProperty("label")]
    public string Label;

    [JsonProperty("name")]
    public string Name;

    [JsonProperty("uri")]
    public string Uri;

    [JsonProperty("proof")]
    public Proof Proof;

    public CharacterTrait() { }

  }

  public class CharacterModel
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("program_id")]
    public string Program_id;

    [JsonProperty("discriminator")]
    public string Discriminator;

    [JsonProperty("bump")]
    public int Bump;

    [JsonProperty("key")]
    public string Key;

    [JsonProperty("project")]
    public string Project;

    [JsonProperty("config")]
    public CharacterConfig Config;

    [JsonProperty("attributes")]
    public object Attributes;

    [JsonProperty("merkle_trees")]
    public ControlledMerkleTrees Merkle_trees;

    public CharacterModel() { }

  }

  public class CharacterConfigWrapped
  {
    [JsonProperty("kind")]
    public string Kind;

    [JsonProperty("criterias")]
    public List<AssetCriteria> Criterias;

    public CharacterConfigWrapped() { }

  }

  public class CharacterConfigAssembled
  {
    [JsonProperty("kind")]
    public string Kind;

    [JsonProperty("assemblerConfig")]
    public string AssemblerConfig;

    [JsonProperty("name")]
    public string Name;

    [JsonProperty("symbol")]
    public string Symbol;

    [JsonProperty("description")]
    public string Description;

    [JsonProperty("creators")]
    public List<NftCreator> Creators;

    [JsonProperty("sellerFeeBasisPoints")]
    public int SellerFeeBasisPoints;

    [JsonProperty("collectionName")]
    public string CollectionName;

    [JsonProperty("mintAs")]
    public MintAs MintAs;

    public CharacterConfigAssembled() { }

  }

  public class NftCreator
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("share")]
    public int Share;

    public NftCreator() { }

  }

  public class MintAs
  {
    [JsonProperty("kind")]
    public MintAsKind Kind;

    [JsonProperty("params")]
    public MintAsParams Params;

    public MintAs() { }

  }

  public class MintAsParamsMplBubblegum
  {
    [JsonProperty("merkleTree")]
    public string MerkleTree;

    public MintAsParamsMplBubblegum() { }

  }

  public class Character
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("tree_id")]
    public string Tree_id;

    [JsonProperty("leaf_idx")]
    public string Leaf_idx;

    [JsonProperty("owner")]
    public string Owner;

    [JsonProperty("source")]
    public CharacterSource Source;

    [JsonProperty("usedBy")]
    public CharacterUsedBy UsedBy;

    [JsonProperty("proof")]
    public Proof Proof;

    [JsonProperty("asset")]
    public object Asset;

    public Character() { }

  }

  public class CharacterSource
  {
    [JsonProperty("kind")]
    public CharacterSourceKind Kind;

    [JsonProperty("params")]
    public CharacterSourceParams Params;

    public CharacterSource() { }

  }

  public class Wrapped
  {
    [JsonProperty("mint")]
    public string Mint;

    [JsonProperty("criteria")]
    public AssetCriteria Criteria;

    [JsonProperty("kind")]
    public SourceKind Kind;

    public Wrapped() { }

  }

  public class AssetCriteria
  {
    [JsonProperty("kind")]
    public AssetCriteriaKind Kind;

    [JsonProperty("params")]
    public string Params;

    public AssetCriteria() { }

  }

  public class Assembled
  {
    [JsonProperty("hash")]
    public string Hash;

    [JsonProperty("mint")]
    public string Mint;

    [JsonProperty("uri")]
    public string Uri;

    [JsonProperty("attributes")]
    public object Attributes;

    [JsonProperty("assemblerConfig")]
    public string AssemblerConfig;

    public Assembled() { }

  }

  public class CharacterUsedBy
  {
    [JsonProperty("kind")]
    public string Kind;

    [JsonProperty("params")]
    public CharacterUsedByParams Params;

    public CharacterUsedBy() { }

  }

  public class UsedByStaking
  {
    [JsonProperty("pool")]
    public string Pool;

    [JsonProperty("staker")]
    public string Staker;

    [JsonProperty("stakedAt")]
    public int StakedAt;

    [JsonProperty("claimedAt")]
    public int ClaimedAt;

    public UsedByStaking() { }

  }

  public class UsedByMission
  {
    [JsonProperty("missionId")]
    public string MissionId;

    [JsonProperty("participationId")]
    public string ParticipationId;

    [JsonProperty("rewards")]
    public List<EarnedRewards> Rewards;

    [JsonProperty("endTime")]
    public int EndTime;

    public UsedByMission() { }

  }

  public class EarnedRewards
  {
    [JsonProperty("delta")]
    public int Delta;

    [JsonProperty("rewardIdx")]
    public int RewardIdx;

    [JsonProperty("collected")]
    public bool Collected;

    public EarnedRewards() { }

  }

  public class UsedByGuild
  {
    [JsonProperty("id")]
    public string Id;

    [JsonProperty("role")]
    public GuildRole Role;

    [JsonProperty("order")]
    public int Order;

    public UsedByGuild() { }

  }

  public class GuildRole
  {
    [JsonProperty("kind")]
    public string Kind;

    public GuildRole() { }

  }

  public class UsedByEjected
  {
    [JsonProperty("mint")]
    public string Mint;

    public UsedByEjected() { }

  }

  public class UsedByCustom
  {
    [JsonProperty("user")]
    public string User;

    [JsonProperty("data")]
    public object Data;

    public UsedByCustom() { }

  }

  public class Global
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("bump")]
    public int Bump;

    [JsonProperty("config")]
    public object Config;

    [JsonProperty("userTrees")]
    public ControlledMerkleTrees UserTrees;

    [JsonProperty("totalUsers")]
    public int TotalUsers;

    public Global() { }

  }

  public class Project
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("bump")]
    public int Bump;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("key")]
    public string Key;

    [JsonProperty("driver")]
    public string Driver;

    [JsonProperty("name")]
    public string Name;

    [JsonProperty("services")]
    public List<Service> Services;

    [JsonProperty("associatedPrograms")]
    public List<AssociatedProgram> AssociatedPrograms;

    [JsonProperty("profileDataConfig")]
    public ProfileDataConfig ProfileDataConfig;

    [JsonProperty("profileTrees")]
    public ControlledMerkleTrees ProfileTrees;

    [JsonProperty("badgeCriteria")]
    public List<BadgeCriteria> BadgeCriteria;

    [JsonProperty("subsidyFees")]
    public bool SubsidyFees;

    public Project() { }

  }

  public class DelegateAuthority
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("bump")]
    public int Bump;

    [JsonProperty("project")]
    public string Project;

    [JsonProperty("authority")]
    public string Authority;

    [JsonProperty("delegations")]
    public List<ServiceDelegation> Delegations;

    public DelegateAuthority() { }

  }

  public class ServiceDelegation
  {
    [JsonProperty("kind")]
    public string Kind;

    [JsonProperty("index")]
    public int Index;

    [JsonProperty("permission")]
    public string Permission;

    public ServiceDelegation() { }

  }

  public class Service
  {
    [JsonProperty("kind")]
    public string Kind;

    [JsonProperty("params")]
    public ServiceParams Params;

    public Service() { }

  }

  public class ServiceParamsAssembler
  {
    [JsonProperty("assemblerId")]
    public string AssemblerId;

    public ServiceParamsAssembler() { }

  }

  public class ServiceParamsAssetManager
  {
    [JsonProperty("assetManagerId")]
    public string AssetManagerId;

    public ServiceParamsAssetManager() { }

  }

  public class ServiceParamsStaking
  {
    [JsonProperty("poolId")]
    public string PoolId;

    public ServiceParamsStaking() { }

  }

  public class ServiceParamsMissions
  {
    [JsonProperty("poolId")]
    public string PoolId;

    public ServiceParamsMissions() { }

  }

  public class ServiceParamsRaffles
  {
    [JsonProperty("poolId")]
    public string PoolId;

    public ServiceParamsRaffles() { }

  }

  public class ServiceParamsGuildKit
  {
    [JsonProperty("kitId")]
    public string KitId;

    public ServiceParamsGuildKit() { }

  }

  public class AssociatedProgram
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("trustedActions")]
    public List<SerializableActions> TrustedActions;

    public AssociatedProgram() { }

  }

  public class SerializableActions
  {
    [JsonProperty("kind")]
    public string Kind;

    public SerializableActions() { }

  }

  public class ProfileDataConfig
  {
    [JsonProperty("achievements")]
    public List<string> Achievements;

    [JsonProperty("customDataFields")]
    public List<string> CustomDataFields;

    public ProfileDataConfig() { }

  }

  public class User
  {
    [JsonProperty("id")]
    public int Id;

    [JsonProperty("address")]
    public string Address;

    [JsonProperty("tree_id")]
    public string Tree_id;

    [JsonProperty("leaf_idx")]
    public string Leaf_idx;

    [JsonProperty("proof")]
    public Proof Proof;

    [JsonProperty("info")]
    public UserInfo Info;

    [JsonProperty("socialInfo")]
    public SocialInfo SocialInfo;

    [JsonProperty("wallets")]
    public Wallets Wallets;

    [JsonProperty("profiles")]
    public List<Profile> Profiles;

    public User() { }

  }

  public class UserInfo
  {
    [JsonProperty("username")]
    public string Username;

    [JsonProperty("name")]
    public string Name;

    [JsonProperty("bio")]
    public string Bio;

    [JsonProperty("pfp")]
    public string Pfp;

    public UserInfo() { }

  }

  public class CivicInfo
  {
    [JsonProperty("gatekeeperNetwork")]
    public CivicGateway GatekeeperNetwork;

    [JsonProperty("expiry")]
    public string Expiry;

    [JsonProperty("walletIndex")]
    public int WalletIndex;

    public CivicInfo() { }

  }

  public class SocialInfo
  {
    [JsonProperty("twitter")]
    public string Twitter;

    [JsonProperty("discord")]
    public string Discord;

    [JsonProperty("steam")]
    public string Steam;

    [JsonProperty("civic")]
    public List<CivicInfo> Civic;

    public SocialInfo() { }

  }

  public class Wallets
  {
    [JsonProperty("shadow")]
    public string Shadow;

    [JsonProperty("wallets")]
    public List<string> Wallets_;

    public Wallets() { }

  }

  public class Profile
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("tree_id")]
    public string Tree_id;

    [JsonProperty("leaf_idx")]
    public string Leaf_idx;

    [JsonProperty("proof")]
    public Proof Proof;

    [JsonProperty("project")]
    public string Project;

    [JsonProperty("userId")]
    public int UserId;

    [JsonProperty("identity")]
    public string Identity;

    [JsonProperty("info")]
    public ProfileInfo Info;

    [JsonProperty("platformData")]
    public PlatformData PlatformData;

    [JsonProperty("customData")]
    public object CustomData;

    [JsonProperty("user")]
    public User User;

    public Profile() { }

  }

  public class ProfileInfo
  {
    [JsonProperty("name")]
    public string Name;

    [JsonProperty("bio")]
    public string Bio;

    [JsonProperty("pfp")]
    public string Pfp;

    public ProfileInfo() { }

  }

  public class PlatformData
  {
    [JsonProperty("custom")]
    public object Custom;

    [JsonProperty("xp")]
    public int Xp;

    [JsonProperty("achievements")]
    public List<int> Achievements;

    public PlatformData() { }

  }

  public class BadgeCriteria
  {
    [JsonProperty("startTime")]
    public string StartTime;

    [JsonProperty("endTime")]
    public string EndTime;

    [JsonProperty("index")]
    public int Index;

    [JsonProperty("condition")]
    public BadgesCondition Condition;

    public BadgeCriteria() { }

  }

  public class Account
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("program_id")]
    public string Program_id;

    [JsonProperty("discriminator")]
    public string Discriminator;

    [JsonProperty("parsed_data")]
    public object Parsed_data;

    public Account() { }

  }

  public class CompressedAccount
  {
    [JsonProperty("tree_id")]
    public string Tree_id;

    [JsonProperty("leaf_idx")]
    public string Leaf_idx;

    [JsonProperty("schema_validated")]
    public bool Schema_validated;

    [JsonProperty("raw_data")]
    public string Raw_data;

    [JsonProperty("parsed_data")]
    public object Parsed_data;

    public CompressedAccount() { }

  }

  public class Node
  {
    [JsonProperty("id")]
    public string Id;

    [JsonProperty("tree")]
    public string Tree;

    [JsonProperty("node_idx")]
    public string Node_idx;

    [JsonProperty("leaf_idx")]
    public string Leaf_idx;

    [JsonProperty("seq")]
    public string Seq;

    [JsonProperty("level")]
    public string Level;

    [JsonProperty("hash")]
    public string Hash;

    public Node() { }

  }

  public class Proof
  {
    [JsonProperty("root")]
    public string Root;

    [JsonProperty("proof")]
    public List<string> Proof_;

    [JsonProperty("node_index")]
    public string Node_index;

    [JsonProperty("leaf")]
    public string Leaf;

    [JsonProperty("maxDepth")]
    public int MaxDepth;

    [JsonProperty("leaf_index")]
    public string Leaf_index;

    [JsonProperty("tree_id")]
    public string Tree_id;

    [JsonProperty("canopy_depth")]
    public int Canopy_depth;

    public Proof() { }

  }

  public class ControlledMerkleTrees
  {
    [JsonProperty("active")]
    public int Active;

    [JsonProperty("schema")]
    public object Schema;

    [JsonProperty("merkle_trees")]
    public List<string> Merkle_trees;

    public ControlledMerkleTrees() { }

  }

  public class MissionPool
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("program_id")]
    public string Program_id;

    [JsonProperty("discriminator")]
    public string Discriminator;

    [JsonProperty("bump")]
    public int Bump;

    [JsonProperty("project")]
    public string Project;

    [JsonProperty("name")]
    public string Name;

    [JsonProperty("factionsMerkleRoot")]
    public string FactionsMerkleRoot;

    [JsonProperty("randomizerRound")]
    public int RandomizerRound;

    [JsonProperty("characterModels")]
    public List<string> CharacterModels;

    [JsonProperty("guildKits")]
    public List<int> GuildKits;

    public MissionPool() { }

  }

  public class Mission
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("program_id")]
    public string Program_id;

    [JsonProperty("discriminator")]
    public string Discriminator;

    [JsonProperty("bump")]
    public int Bump;

    [JsonProperty("project")]
    public string Project;

    [JsonProperty("missionPool")]
    public string MissionPool;

    [JsonProperty("name")]
    public string Name;

    [JsonProperty("minXp")]
    public string MinXp;

    [JsonProperty("cost")]
    public MissionCost Cost;

    [JsonProperty("requirement")]
    public MissionRequirement Requirement;

    [JsonProperty("rewards")]
    public List<Reward> Rewards;

    public Mission() { }

  }

  public class MissionCost
  {
    [JsonProperty("amount")]
    public string Amount;

    [JsonProperty("resource_address")]
    public string Resource_address;

    public MissionCost() { }

  }

  public class TimeRequirement
  {
    [JsonProperty("kind")]
    public string Kind;

    [JsonProperty("params")]
    public TimeRequirementParams Params;

    public TimeRequirement() { }

  }

  public class TimeRequirementParams
  {
    [JsonProperty("duration")]
    public string Duration;

    public TimeRequirementParams() { }

  }

  public class Reward
  {
    [JsonProperty("min")]
    public string Min;

    [JsonProperty("max")]
    public string Max;

    [JsonProperty("rewardType")]
    public RewardType RewardType;

    public Reward() { }

  }

  public class XpRewardType
  {
    [JsonProperty("kind")]
    public string Kind;

    public XpRewardType() { }

  }

  public class ResourceRewardType
  {
    [JsonProperty("kind")]
    public string Kind;

    [JsonProperty("params")]
    public ResourceRewardTypeParams Params;

    public ResourceRewardType() { }

  }

  public class ResourceRewardTypeParams
  {
    [JsonProperty("address")]
    public string Address;

    public ResourceRewardTypeParams() { }

  }

  public class StakingPool
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("bump")]
    public int Bump;

    [JsonProperty("project")]
    public string Project;

    [JsonProperty("key")]
    public string Key;

    [JsonProperty("resource")]
    public string Resource;

    [JsonProperty("lockType")]
    public LockType LockType;

    [JsonProperty("name")]
    public string Name;

    [JsonProperty("rewardsPerDuration")]
    public string RewardsPerDuration;

    [JsonProperty("rewardsDuration")]
    public string RewardsDuration;

    [JsonProperty("maxRewardsDuration")]
    public string MaxRewardsDuration;

    [JsonProperty("minStakeDuration")]
    public string MinStakeDuration;

    [JsonProperty("cooldownDuration")]
    public string CooldownDuration;

    [JsonProperty("resetStakeDuration")]
    public bool ResetStakeDuration;

    [JsonProperty("allowedMints")]
    public bool AllowedMints;

    [JsonProperty("totalStaked")]
    public string TotalStaked;

    [JsonProperty("startTime")]
    public string StartTime;

    [JsonProperty("endTime")]
    public string EndTime;

    [JsonProperty("characterModels")]
    public List<string> CharacterModels;

    public StakingPool() { }

  }

  public class LockType
  {
    [JsonProperty("kind")]
    public string Kind;

    public LockType() { }

  }

  public class Multipliers
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("bump")]
    public int Bump;

    [JsonProperty("stakingPool")]
    public string StakingPool;

    [JsonProperty("decimals")]
    public int Decimals;

    [JsonProperty("durationMultipliers")]
    public List<Multiplier> DurationMultipliers;

    [JsonProperty("countMultipliers")]
    public List<Multiplier> CountMultipliers;

    [JsonProperty("creatorMultipliers")]
    public List<Multiplier> CreatorMultipliers;

    [JsonProperty("collectionMultipliers")]
    public List<Multiplier> CollectionMultipliers;

    public Multipliers() { }

  }

  public class Multiplier
  {
    [JsonProperty("value")]
    public string Value;

    [JsonProperty("multiplierType")]
    public MultiplierType MultiplierType;

    public Multiplier() { }

  }

  public class MultiplierType
  {
    [JsonProperty("kind")]
    public string Kind;

    [JsonProperty("params")]
    public MultiplierTypeParams Params;

    public MultiplierType() { }

  }

  public class MultiplierTypeParamsStakeDuration
  {
    [JsonProperty("minDuration")]
    public string MinDuration;

    public MultiplierTypeParamsStakeDuration() { }

  }

  public class MultiplierTypeParamsNFTCount
  {
    [JsonProperty("minCount")]
    public string MinCount;

    public MultiplierTypeParamsNFTCount() { }

  }

  public class MultiplierTypeParamsCreator
  {
    [JsonProperty("creator")]
    public string Creator;

    public MultiplierTypeParamsCreator() { }

  }

  public class MultiplierTypeParamsCollection
  {
    [JsonProperty("collection")]
    public string Collection;

    public MultiplierTypeParamsCollection() { }

  }

  public class Staker
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("bump")]
    public int Bump;

    [JsonProperty("stakingPool")]
    public string StakingPool;

    [JsonProperty("wallet")]
    public string Wallet;

    [JsonProperty("totalStaked")]
    public string TotalStaked;

    public Staker() { }

  }

  public class Transaction
  {
    [JsonProperty("transaction")]
    public string Transaction_;

    [JsonProperty("blockhash")]
    public string Blockhash;

    [JsonProperty("lastValidBlockHeight")]
    public int LastValidBlockHeight;

    public Transaction() { }

  }

  public class CreateCreateProjectTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx;

    [JsonProperty("project")]
    public string Project;

    public CreateCreateProjectTransactionResponse() { }

  }

  public class CreateAssemblerConfigTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx;

    [JsonProperty("assemblerConfig")]
    public string AssemblerConfig;

    [JsonProperty("treeAddress")]
    public string TreeAddress;

    [JsonProperty("proofBytes")]
    public int ProofBytes;

    [JsonProperty("space")]
    public int Space;

    [JsonProperty("cost")]
    public float Cost;

    [JsonProperty("maxTreeCapacity")]
    public int MaxTreeCapacity;

    public CreateAssemblerConfigTransactionResponse() { }

  }

  public class CreateCharacterModelTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx;

    [JsonProperty("characterModel")]
    public string CharacterModel;

    public CreateCharacterModelTransactionResponse() { }

  }

  public class CreateInitResourceTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx;

    [JsonProperty("resource")]
    public string Resource;

    public CreateInitResourceTransactionResponse() { }

  }

  public class CreateCreateNewResourceTreeTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx;

    [JsonProperty("tree")]
    public string Tree;

    public CreateCreateNewResourceTreeTransactionResponse() { }

  }

  public class CreateInitializeRecipeTransactionResponse
  {
    [JsonProperty("transactions")]
    public Transactions Transactions;

    [JsonProperty("recipe")]
    public string Recipe;

    public CreateInitializeRecipeTransactionResponse() { }

  }

  public class CreateBeginCookingTransactionResponse
  {
    [JsonProperty("transaction")]
    public Transaction Transaction;

    [JsonProperty("cooking")]
    public string Cooking;

    public CreateBeginCookingTransactionResponse() { }

  }

  public class Transactions
  {
    [JsonProperty("transactions")]
    public List<string> Transactions_;

    [JsonProperty("blockhash")]
    public string Blockhash;

    [JsonProperty("lastValidBlockHeight")]
    public int LastValidBlockHeight;

    public Transactions() { }

  }

  public class TransactionResponse
  {
    [JsonProperty("signature")]
    public string Signature;

    [JsonProperty("error")]
    public object Error;

    [JsonProperty("status")]
    public string Status;

    public TransactionResponse() { }

  }

  public class TransactionBundleResponse
  {
    [JsonProperty("bundleId")]
    public int BundleId;

    [JsonProperty("responses")]
    public List<TransactionResponse> Responses;

    public TransactionBundleResponse() { }

  }

  public class AuthResponse
  {
    [JsonProperty("message")]
    public string Message;

    [JsonProperty("tx")]
    public string Tx;

    public AuthResponse() { }

  }

  public class AuthConfirmed
  {
    [JsonProperty("accessToken")]
    public string AccessToken;

    [JsonProperty("user")]
    public User User;

    public AuthConfirmed() { }

  }

  public class OutputHoldingTree
  {
    [JsonProperty("tree")]
    public string Tree;

    public OutputHoldingTree() { }

  }

  public class CreateCreateHolderAccountTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx;

    [JsonProperty("holderAccount")]
    public string HolderAccount;

    public CreateCreateHolderAccountTransactionResponse() { }

  }

  public class CreateInitMultipliersTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx;

    [JsonProperty("multipliersAddress")]
    public string MultipliersAddress;

    public CreateInitMultipliersTransactionResponse() { }

  }

  public class CreateCreateStakingPoolTransactionResponse
  {
    [JsonProperty("transactions")]
    public Transactions Transactions;

    [JsonProperty("stakingPoolAddress")]
    public string StakingPoolAddress;

    [JsonProperty("multipliersAddress")]
    public string MultipliersAddress;

    public CreateCreateStakingPoolTransactionResponse() { }

  }

  public class CreateCreateMissionPoolTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx;

    [JsonProperty("missionPoolAddress")]
    public string MissionPoolAddress;

    public CreateCreateMissionPoolTransactionResponse() { }

  }

  public class CreateUpdateMissionPoolTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx;

    public CreateUpdateMissionPoolTransactionResponse() { }

  }

  public class CreateCreateMissionTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx;

    [JsonProperty("missionAddress")]
    public string MissionAddress;

    public CreateCreateMissionTransactionResponse() { }

  }

  public class CreateUpdateMissionTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx;

    public CreateUpdateMissionTransactionResponse() { }

  }

  public class CreateInitializeFaucetTransactionResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx;

    [JsonProperty("faucet")]
    public string Faucet;

    public CreateInitializeFaucetTransactionResponse() { }

  }

  public class TreeSetupResponse
  {
    [JsonProperty("tx")]
    public Transaction Tx;

    [JsonProperty("treeAddress")]
    public string TreeAddress;

    [JsonProperty("proofBytes")]
    public int ProofBytes;

    [JsonProperty("space")]
    public int Space;

    [JsonProperty("cost")]
    public float Cost;

    [JsonProperty("maxTreeCapacity")]
    public int MaxTreeCapacity;

    public TreeSetupResponse() { }

  }

  public class Resource
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("bump")]
    public int Bump;

    [JsonProperty("project")]
    public string Project;

    [JsonProperty("mint")]
    public string Mint;

    [JsonProperty("storage")]
    public ResourceStorage Storage;

    [JsonProperty("kind")]
    public ResourceKind Kind;

    public Resource() { }

  }

  public class ResourceBalance
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("amount")]
    public string Amount;

    [JsonProperty("mint")]
    public string Mint;

    [JsonProperty("wallet")]
    public string Wallet;

    [JsonProperty("resourceStorage")]
    public ResourceStorageEnum ResourceStorage;

    public ResourceBalance() { }

  }

  public class ResourceStorage
  {
    [JsonProperty("kind")]
    public ResourceStorageEnum Kind;

    [JsonProperty("params")]
    public ResourceStorageParams Params;

    public ResourceStorage() { }

  }

  public class ResourceStorageParams
  {
    [JsonProperty("merkle_trees")]
    public ControlledMerkleTrees Merkle_trees;

    [JsonProperty("promiseSupply")]
    public string PromiseSupply;

    public ResourceStorageParams() { }

  }

  public class ResourceKind
  {
    [JsonProperty("kind")]
    public string Kind;

    [JsonProperty("params")]
    public ResourceKindParams Params;

    public ResourceKind() { }

  }

  public class ResourceKindParamsHplFungible
  {
    [JsonProperty("decimals")]
    public int Decimals;

    public ResourceKindParamsHplFungible() { }

  }

  public class ResourceKindParamsWrappedFungible
  {
    [JsonProperty("decimals")]
    public int Decimals;

    [JsonProperty("custody")]
    public ResourceCustody Custody;

    public ResourceKindParamsWrappedFungible() { }

  }

  public class ResourceCustody
  {
    [JsonProperty("kind")]
    public ResourceCustodyEnum Kind;

    [JsonProperty("params")]
    public ResourceCustodyParams Params;

    public ResourceCustody() { }

  }

  public class ResourceCustodyParams
  {
    [JsonProperty("burnerDestination")]
    public string BurnerDestination;

    public ResourceCustodyParams() { }

  }

  public class ResourceKindParamsHplNonFungible
  {
    [JsonProperty("characteristics")]
    public List<string> Characteristics;

    public ResourceKindParamsHplNonFungible() { }

  }

  public class ResourceKindParamsWrappedMplCore
  {
    [JsonProperty("characteristics")]
    public List<string> Characteristics;

    public ResourceKindParamsWrappedMplCore() { }

  }

  public class Recipe
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("bump")]
    public int Bump;

    [JsonProperty("project")]
    public string Project;

    [JsonProperty("key")]
    public string Key;

    [JsonProperty("xp")]
    public string Xp;

    [JsonProperty("ingredients")]
    public List<Ingredient> Ingredients;

    [JsonProperty("meal")]
    public Meal Meal;

    public Recipe() { }

  }

  public class Ingredient
  {
    [JsonProperty("resourceAddress")]
    public string ResourceAddress;

    [JsonProperty("amount")]
    public string Amount;

    public Ingredient() { }

  }

  public class Meal
  {
    [JsonProperty("resourceAddress")]
    public string ResourceAddress;

    [JsonProperty("amount")]
    public string Amount;

    public Meal() { }

  }

  public class Faucet
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("project")]
    public string Project;

    [JsonProperty("resource")]
    public string Resource;

    [JsonProperty("amount")]
    public string Amount;

    [JsonProperty("repeatInterval")]
    public string RepeatInterval;

    [JsonProperty("lastClaimed")]
    public string LastClaimed;

    public Faucet() { }

  }

  public class Holding
  {
    [JsonProperty("address")]
    public string Address;

    [JsonProperty("tree_id")]
    public string Tree_id;

    [JsonProperty("leaf_idx")]
    public string Leaf_idx;

    [JsonProperty("holder")]
    public string Holder;

    [JsonProperty("balance")]
    public string Balance;

    [JsonProperty("characteristics")]
    public object Characteristics;

    [JsonProperty("proof")]
    public Proof Proof;

    public Holding() { }

  }

}

